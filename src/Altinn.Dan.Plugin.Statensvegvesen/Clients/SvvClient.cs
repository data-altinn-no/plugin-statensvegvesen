using Altinn.Dan.Plugin.Statensvegvesen.Config;
using Altinn.Dan.Plugin.Statensvegvesen.Models;
using Dan.Common.Exceptions;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Altinn.Dan.Plugin.Statensvegvesen.Clients
{
    public class SvvClient
    {
        private readonly HttpClient _httpClient;
        private readonly ApplicationSettings _settings;
        private const string verkstedKeyHeader = "x-api-key";

        public SvvClient(IHttpClientFactory httpClientFactory, IOptions<ApplicationSettings> settings)
        {
            _httpClient = httpClientFactory.CreateClient("SvvClient");
            _settings = settings.Value;
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
