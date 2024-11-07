using Altinn.Dan.Plugin.Statensvegvesen.Config;
using Dan.Common.Exceptions;
using Dan.Common.Models;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Altinn.Dan.Plugin.Statensvegvesen.Clients
{


    public interface IDanPluginClientService
    {
        public Task<T> GetPluginDataSetAsync<T>(EvidenceHarvesterRequest request, string code, string env, bool isDefaultJson, string url = "", string source = "") where T: new();
    }
    public class DanPluginClientService : IDanPluginClientService
    {
        private readonly HttpClient _httpClient;
        private readonly ApplicationSettings _settings;

        private string clientName = "SafeHttpClient";

        private string metadata_dev = "https://dev-api.data.altinn.no/v1/public/metadata/evidencecodes";
        private string metadata_test = "https://test-api.data.altinn.no/v1/public/metadata/evidencecodes";
        private string metadata_prod = "https://api.data.altinn.no/v1/public/metadata/evidencecodes";

        private string plugin_dev = "https://func-es{0}-test-dev.azurewebsites.net/api/{1}?code={2}";
        private string plugin_test = "https://func-es{0}-prod-prod-staging.azurewebsites.net/api/{1}?code={2}";
        private string plugin_prod = "https://func-es{0}-prod-prod.azurewebsites.net/api/{1}?code={2}";

        public DanPluginClientService(IHttpClientFactory httpClientFactory, IOptions<ApplicationSettings> settings)
        {
            _httpClient = httpClientFactory.CreateClient(clientName);
            _settings = settings.Value;
        }

        private string GetPluginUrl(string env, string source, string evidenceCodeName, string code)
        {
            string result = env switch
            {
                "dev" => string.Format(plugin_dev, source, evidenceCodeName, code),
                "test" => string.Format(plugin_test, source, evidenceCodeName, code),
                "prod" => string.Format(plugin_prod, source, evidenceCodeName, code),
                _ => throw new ArgumentOutOfRangeException(nameof(env), $"env must be dev, test or prod"),
            };

            return result;
        }

        public async Task<T> GetPluginDataSetAsync<T>(EvidenceHarvesterRequest request, string code, string env, bool isDefaultJson, string pluginUrl = "", string source = "") where T : new()
        {
            HttpResponseMessage response = null;
            List<EvidenceCode> evidenceCodes = null;
            EvidenceCode evidenceCode = null;

            var result = default(T);

            try
            {
                string url = env switch
                    {
                        "dev" => metadata_dev,
                        "test" => metadata_test,
                        "prod" => metadata_prod,
                        _ => throw new ArgumentOutOfRangeException(nameof(env), $"env must be dev, test or prod"),
                    };
                
                var metadataResponse = await _httpClient.GetAsync(url);
                if (metadataResponse.IsSuccessStatusCode)
                {
                    evidenceCodes = JsonConvert.DeserializeObject<List<EvidenceCode>>(await metadataResponse.Content.ReadAsStringAsync());
                    evidenceCode = evidenceCodes.Where(x => x.EvidenceCodeName == request.EvidenceCodeName).FirstOrDefault();

                    if (evidenceCode == null)
                    {
                        throw new EvidenceSourceTransientException(1, "Dataset not found");
                    }

                    if (!string.IsNullOrEmpty(evidenceCode.RequiredScopes))
                    {
                        throw new ArgumentOutOfRangeException(nameof(request.MPToken), $"Dataset requires maskinporten token which was not supplied");
                    }
                }
                else
                {
                    throw new EvidenceSourceTransientException(1, "Dataset not found");
                }

                pluginUrl = string.IsNullOrEmpty(pluginUrl) ? GetPluginUrl(env, source, evidenceCode.EvidenceCodeName, code) : pluginUrl;

                response = await _httpClient.PostAsync(pluginUrl, new StringContent(JsonConvert.SerializeObject(request),Encoding.UTF8, "application/json"));

                switch (response.StatusCode)
                {
                    case HttpStatusCode.OK:
                    {
                        var content = await response.Content.ReadAsStringAsync();

                        if (isDefaultJson)
                        {
                            var tmp = JsonConvert.DeserializeObject<List<EvidenceValue>>(content);
                            var evValue = tmp.Where(x => x.EvidenceValueName == "default").First();
                            result = JsonConvert.DeserializeObject<T>(evValue.Value.ToString());
                        }
                        else
                        {
                            result = JsonConvert.DeserializeObject<T>(content);
                        }
                    }

                        break;
                    case HttpStatusCode.NoContent:
                        throw new EvidenceSourcePermanentClientException(Metadata.ERROR_CCR_UPSTREAM_ERROR, $"Unexpected HTTP status code from external API");
                    case HttpStatusCode.BadRequest:
                        throw new EvidenceSourcePermanentClientException(Metadata.ERROR_BAD_REQUEST, $"Bad request");
                    case HttpStatusCode.UnprocessableEntity:
                        throw new EvidenceSourceTransientException(Metadata.ERROR_QUOTA_EXCEEDED, $"Quota exceeded. Try again tomorrow.");
                    default:
                        throw new EvidenceSourcePermanentClientException(Metadata.ERROR_CCR_UPSTREAM_ERROR, $"Unexpected HTTP status code from external API");
                }

            }
            catch (HttpRequestException ex)
            {
                throw new EvidenceSourcePermanentServerException(Metadata.ERROR_CCR_UPSTREAM_ERROR, null, ex);
            }
            finally
            {
                response?.Dispose();
            }

            return result;
        }
    }
}
