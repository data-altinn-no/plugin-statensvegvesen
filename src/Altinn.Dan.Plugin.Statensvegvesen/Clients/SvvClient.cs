using Altinn.Dan.Plugin.Statensvegvesen.Config;
using Altinn.Dan.Plugin.Statensvegvesen.Models;
using Dan.Common.Exceptions;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Altinn.Dan.Plugin.Statensvegvesen.Clients
{
    public class SvvClient
    {
        private readonly HttpClient _httpClient;
        private readonly HttpClient _kjoretoyClient;
        private readonly ApplicationSettings _settings;
        private const string verkstedKeyHeader = "x-api-key";
        private const int PAGE = 0;
        private const int ITEMCOUNT = 100;

        public SvvClient(IHttpClientFactory httpClientFactory, IOptions<ApplicationSettings> settings)
        {
            _httpClient = httpClientFactory.CreateClient("SvvClient");
            _settings = settings.Value;
            _kjoretoyClient = httpClientFactory.CreateClient("kjoretoyclient");
        }

        public async Task<KjoretoysokResponse> SokKjoretoyForFodselsnummer(string fodselsnummer)
        {
            if (string.IsNullOrEmpty(fodselsnummer))
            {
                throw new EvidenceSourcePermanentClientException(Metadata.ERROR_BAD_REQUEST, $"Bad request (argument cannot be empty)");
            }

            HttpResponseMessage response = null;
            try
            {
                var urlBuilder = new StringBuilder();
                urlBuilder.Append("?fodselsnummer=").Append(Uri.EscapeDataString(fodselsnummer));
                response = await _httpClient.GetAsync(urlBuilder.ToString());
                switch (response.StatusCode)
                {
                    case HttpStatusCode.OK:
                    {
                        var kjoretoysokResponse = JsonConvert.DeserializeObject<KjoretoysokResponse>(await response.Content.ReadAsStringAsync());

                        return kjoretoysokResponse;
                    }
                    case HttpStatusCode.NoContent:
                    {
                        return null;
                    }
                    case HttpStatusCode.BadRequest:
                    {
                        throw new EvidenceSourcePermanentClientException(Metadata.ERROR_BAD_REQUEST, $"Bad request");
                    }
                    default:
                    {
                        throw new EvidenceSourcePermanentClientException(Metadata.ERROR_CCR_UPSTREAM_ERROR, $"Unexpected HTTP status code from external API");
                    }
                }
            }
            catch (HttpRequestException e)
            {
                throw new EvidenceSourcePermanentServerException(Metadata.ERROR_CCR_UPSTREAM_ERROR, null, e);
            }
            finally
            {
                response?.Dispose();
            }
        }

        public async Task<List<DueDiligenceVehicle>> SokKjoretoyForOrgnummer(string orgnummer)
        {
            HttpResponseMessage response = null;
            try
            {

                var url = string.Format(_settings.KjoretoyUrl, orgnummer, PAGE, ITEMCOUNT);

                response = await _kjoretoyClient.GetAsync(url);
                switch (response.StatusCode)
                {
                    case HttpStatusCode.OK:
                    {
                        var responsestring = await response.Content.ReadAsStringAsync();
                        var kjoretoysokResponse = JsonConvert.DeserializeObject<OrganisasjonsnummerResponse>(responsestring);
                            
                        return MapToExternal(kjoretoysokResponse, orgnummer);
                    }
                    case HttpStatusCode.NoContent:
                    {
                        return null;
                    }
                    case HttpStatusCode.BadRequest:
                    {
                        throw new EvidenceSourcePermanentClientException(Metadata.ERROR_BAD_REQUEST, $"Bad request");
                    }
                    case HttpStatusCode.UnprocessableEntity:
                    {
                        throw new EvidenceSourceTransientException(Metadata.ERROR_QUOTA_EXCEEDED, $"Vehicles exceed quota");
                        }
                    default:
                    {
                        throw new EvidenceSourcePermanentClientException(Metadata.ERROR_CCR_UPSTREAM_ERROR, $"Unexpected HTTP status code from external API");
                    }
                }
            }
            catch (HttpRequestException e)
            {
                throw new EvidenceSourcePermanentServerException(Metadata.ERROR_CCR_UPSTREAM_ERROR, null, e);
            }
            finally
            {
                response?.Dispose();
            }
        }

        private List<DueDiligenceVehicle> MapToExternal(OrganisasjonsnummerResponse sok, string orgno)
        {
            var result = new List<DueDiligenceVehicle>();

            foreach (var car in sok.KjoretoydataListe)
            {
                var vehicle = new DueDiligenceVehicle
                {
                    Leased = car.Kjoretoydata.Eierskap.Leasingtaker?.Enhet?.Organisasjonsnummer == orgno,
                    Brand = string.Join(",", car.Kjoretoydata.Godkjenning.TekniskGodkjenning.TekniskeData.Generelt.Merke.Select(x=>x.Merke1)),
                    Number = car.Kjoretoydata.KjoretoyId.Kjennemerke,
                    Ownership = car.Kjoretoydata.Eierskap.Eier?.Enhet?.Organisasjonsnummer == orgno,
                    VehicleGroup = string.Join(",", car.Kjoretoydata.Kjennemerke.Select(x=>x.Kjennemerketype.KodeNavn)),         //car.Kjoretoydata.Godkjenning.TekniskGodkjenning.Kjoretoyklassifisering.TekniskKode.KodeNavn,
                    LastPassedEUControl =  car.Kjoretoydata.PeriodiskKjoretoyKontroll.SistGodkjent == null ? "" : car.Kjoretoydata.PeriodiskKjoretoyKontroll.SistGodkjent.ToString(),
                    FirstRegisteredDateTime = car.Kjoretoydata.Forstegangsregistrering.RegistrertForstegangNorgeDato.ToString(),
                    VIN = car.Kjoretoydata.KjoretoyId.Understellsnummer,
                    MileageRegisteredDateTime = "",
                    CO2 = car.Kjoretoydata.Godkjenning.TekniskGodkjenning.TekniskeData.Miljodata?.MiljoOgdrivstoffGruppe[0]?.ForbrukOgUtslipp[0]?.Co2BlandetKjoring,
                    EnvironmentClassification = string.Join(", ", car.Kjoretoydata.Godkjenning.TekniskGodkjenning.TekniskeData.Miljodata.MiljoOgdrivstoffGruppe.Select(x => x.DrivstoffKodeMiljodata.KodeNavn)),
                    FuelType = car.Kjoretoydata.Godkjenning.TekniskGodkjenning.TekniskeData.Miljodata.EuroKlasse.KodeVerdi.ToString(),
                    GearBoxType = car.Kjoretoydata.Godkjenning.TekniskGodkjenning.TekniskeData.MotorOgDrivverk.Girkassetype?.KodeNavn,
                    Mileage = -1,
                    NOx = car.Kjoretoydata.Godkjenning.TekniskGodkjenning.TekniskeData.Miljodata.MiljoOgdrivstoffGruppe[0].ForbrukOgUtslipp[0].UtslippNOxMgPrKm,
                };

                result.Add(vehicle);
                    
            }

            return result;
        }

        public async Task<List<Verksted>> GetVerkstedRegister(string organizationNumber)
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, string.Format(_settings.SvvBilpleieUrl, organizationNumber));
            request.Headers.TryAddWithoutValidation(verkstedKeyHeader, _settings.SvvBilpleieKey);

            HttpResponseMessage response = null;
            try
            {
                response = await _httpClient.SendAsync(request);

                switch (response.StatusCode)
                {
                    case HttpStatusCode.OK:
                    {
                        return JsonConvert.DeserializeObject<List<Verksted>>(await response.Content.ReadAsStringAsync());
                    }
                    case HttpStatusCode.NoContent:
                    {
                        throw new EvidenceSourcePermanentClientException(Metadata.ERROR_CCR_UPSTREAM_ERROR, $"Unexpected HTTP status code from external API");
                        }
                    case HttpStatusCode.BadRequest:
                    {
                        throw new EvidenceSourcePermanentClientException(Metadata.ERROR_BAD_REQUEST, $"Bad request");
                    }
                    default:
                    {
                        throw new EvidenceSourcePermanentClientException(Metadata.ERROR_CCR_UPSTREAM_ERROR, $"Unexpected HTTP status code from external API");
                    }
                }
            }
            catch (HttpRequestException e)
            {
                throw new EvidenceSourcePermanentServerException(Metadata.ERROR_CCR_UPSTREAM_ERROR, null, e);
            }
            finally
            {
               response?.Dispose();
            }
        }
    }
}
