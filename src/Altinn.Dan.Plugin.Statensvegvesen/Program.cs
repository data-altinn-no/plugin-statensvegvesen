using System;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Altinn.ApiClients.Maskinporten.Config;
using Altinn.ApiClients.Maskinporten.Extensions;
using Altinn.ApiClients.Maskinporten.Services;
using Altinn.Dan.Plugin.Statensvegvesen.Clients;
using Altinn.Dan.Plugin.Statensvegvesen.Config;
using Dan.Common;
using Dan.Common.Extensions;
using Dan.Plugin.Statensvegvesen.Config;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Polly;
using Polly.Caching.Distributed;
using Polly.Extensions.Http;
using Polly.Registry;

namespace Altinn.Dan.Plugin.Statensvegvesen;

internal class Program
{
    private static ApplicationSettings ApplicationSettings { get; set; }

    private static Task Main(string[] args)
    {
        var host = new HostBuilder()
            .ConfigureDanPluginDefaults()
            .ConfigureServices((context, services) =>
            {

                var configurationRoot = context.Configuration;


                services.AddLogging();
                // See https://docs.microsoft.com/en-us/azure/azure-monitor/app/worker-service#using-application-insights-sdk-for-worker-services
                services.AddApplicationInsightsTelemetryWorkerService();

                services.AddScoped<SvvClient>();

                services.AddOptions<ApplicationSettings>()
                    .Configure<IConfiguration>((settings, configuration) => configuration.Bind(settings));
                ApplicationSettings = services.BuildServiceProvider().GetRequiredService<IOptions<ApplicationSettings>>().Value;

                services.AddStackExchangeRedisCache(option => { option.Configuration = ApplicationSettings.RedisConnectionString; });

                var distributedCache = services.BuildServiceProvider().GetRequiredService<IDistributedCache>();
                var registry = new PolicyRegistry
                {
                    { "defaultCircuitBreaker", HttpPolicyExtensions.HandleTransientHttpError().CircuitBreakerAsync(4, ApplicationSettings.BreakerRetryWaitTime) },
                    { "CachePolicy", Policy.CacheAsync(distributedCache.AsAsyncCacheProvider<string>(), TimeSpan.FromHours(12)) }
                };
                services.AddPolicyRegistry(registry);

                services.AddHttpClient("SvvClient", (provider, client) =>
                {
                    client.Timeout = new TimeSpan(0, 0, 30);
                    client.BaseAddress = new Uri(ApplicationSettings.SvvUrl);
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
                        Convert.ToBase64String(Encoding.ASCII.GetBytes($"{ApplicationSettings.SvvUsername}:{ApplicationSettings.SvvPassword}")));
                }).AddPolicyHandlerFromRegistry("defaultCircuitBreaker");

                JsonConvert.DefaultSettings = () => new JsonSerializerSettings
                {
                    DefaultValueHandling = DefaultValueHandling.Ignore,
                    ContractResolver = new CamelCasePropertyNamesContractResolver()
                };

                services.AddMaskinportenHttpClient<KeyVaultMaskinportenClientDefinition>("kjoretoyclient",configurationRoot.GetSection("MPKjoretoy"),
                        clientDefinition =>
                        {
                            configurationRoot.GetSection("MPKjoretoy").Bind(clientDefinition.KeyVaultMaskinportenSettings);
                        })
                    .AddPolicyHandlerFromRegistry("defaultCircuitBreaker");
            })
            .Build();

        return host.RunAsync();
    }
}
