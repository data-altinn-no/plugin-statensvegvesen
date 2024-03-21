using Altinn.ApiClients.Maskinporten.Config;
using Altinn.ApiClients.Maskinporten.Interfaces;

namespace Dan.Plugin.Statensvegvesen.Config
{
    public class KeyVaultMaskinportenSettings : MaskinportenSettings
    {
        public string AzureKeyVaultName { get; set; }
        public string SecretName { get; set; }
    }
}
