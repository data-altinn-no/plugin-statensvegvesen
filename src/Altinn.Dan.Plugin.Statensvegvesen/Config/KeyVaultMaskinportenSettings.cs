using Altinn.ApiClients.Maskinporten.Config;

namespace Dan.Plugin.Statensvegvesen.Config
{
    public class KeyVaultMaskinportenSettings : MaskinportenSettings
    {
        public string AzureKeyVaultName { get; set; }
        public string SecretName { get; set; }
    }
}
