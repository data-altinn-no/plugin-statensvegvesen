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
using Altinn.Dan.Plugin.Brreg.Models;
using Altinn.Dan.Plugin.Statensvegvesen.Utils;
using Dan.Common.Models;

namespace Altinn.Dan.Plugin.Statensvegvesen.Clients
{
    public class SvvClient
    {
        private readonly HttpClient _httpClient;
        private readonly HttpClient _kjoretoyClient;
        private readonly IDanPluginClientService _danClientService;
        private readonly ApplicationSettings _settings;
        private const string verkstedKeyHeader = "x-api-key";
        private const int PAGE = 0;
        private const int ITEMCOUNT = 100;

        public SvvClient(IHttpClientFactory httpClientFactory, IOptions<ApplicationSettings> settings, IDanPluginClientService danService)
        {
            _httpClient = httpClientFactory.CreateClient("SvvClient");
            _settings = settings.Value;
            _kjoretoyClient = httpClientFactory.CreateClient("kjoretoyclient");
            _danClientService = danService;
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

        private async Task<LosoreV2> GetHeftelser(string regnr, string orgnr)
        {
            var evHaReq = new EvidenceHarvesterRequest()
            {
                SubjectParty = new Party()
                {
                    NorwegianOrganizationNumber = orgnr
                },
                EvidenceCodeName = "RettsstiftelserKjoretoy",
                Parameters = new List<EvidenceParameter>()
                    { new EvidenceParameter() { EvidenceParamName = "Registreringsnummer", Value = regnr } },
            };

           return await _danClientService.GetPluginDataSetAsync<LosoreV2>(evHaReq, _settings.PluginCode, _settings.Env, true, "", "brreg");
        }

        public async Task<List<DueDiligenceVehicle>> SokKjoretoyForOrgnummer(string orgnummer, int side = PAGE, int antall = ITEMCOUNT, bool includeCharges = false)
        {
            HttpResponseMessage response = null;
            try
            {

                var url = string.Format(_settings.KjoretoyUrl, orgnummer, side, antall);

                response = await _kjoretoyClient.GetAsync(url);
                switch (response.StatusCode)
                {
                    case HttpStatusCode.OK:
                    {
                        var responsestring = await response.Content.ReadAsStringAsync();
                        var kjoretoysokResponse = JsonConvert.DeserializeObject<OrganisasjonsnummerResponse>(responsestring);

                        var vehicleList = DueDiligenceUtils.MapToExternal(kjoretoysokResponse, orgnummer);

                        if (includeCharges)
                            {
                                var taskList = new List<Task<LosoreV2>>();
                                foreach (var regnr in vehicleList)
                                {
                                    //Temp testdata fix
                                    if (_settings.Env != "prod")
                                    {
                                        regnr.Number = "AB52874";
                                    }
                                    taskList.Add(GetHeftelser(regnr.Number, orgnummer));
                                }

                                await Task.WhenAll(taskList);

                                foreach (var vehicle in vehicleList)
                                {
                                    var resultCharges = taskList.Where(x => x.Result.sokeparameter == vehicle.Number).First().Result;
                                    vehicle.Charges = resultCharges;
                                }
                            }
    

                        return vehicleList;
                    }
                    case HttpStatusCode.NoContent:
                    {
                        throw new EvidenceSourcePermanentClientException(Metadata.ERROR_CCR_UPSTREAM_ERROR, $"Unexpected HTTP status code from external API");
                        }
                    case HttpStatusCode.BadRequest:
                    {
                        throw new EvidenceSourcePermanentClientException(Metadata.ERROR_BAD_REQUEST, $"Bad request");
                    }
                    case HttpStatusCode.UnprocessableEntity:
                    {
                        throw new EvidenceSourceTransientException(Metadata.ERROR_QUOTA_EXCEEDED, $"Quota exceeded. Try again tomorrow.");
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
