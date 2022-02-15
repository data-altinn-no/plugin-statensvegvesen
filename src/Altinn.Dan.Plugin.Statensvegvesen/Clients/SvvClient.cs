using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Nadobe.Common.Exceptions;
using Newtonsoft.Json;

namespace Altinn.Dan.Plugin.Statensvegvesen.Clients
{
    public class SvvClient
    {
        private readonly HttpClient _httpClient;

        public SvvClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        /// <param name="fodselsnummer">Fødselsnummer på eier, medeier eller leasingtaker</param>
        /// <returns>Søk gjennomført, responsen inneholder eventuelle treff og/eller responskoder</returns>
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
                        throw new EvidenceSourcePermanentClientException(Metadata.ERROR_NO_VEHICLES_FOUND, $"No vehicles found");
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
