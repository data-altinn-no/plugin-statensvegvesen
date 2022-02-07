using System.Collections.Generic;
using Altinn.Dan.Plugin.Statensvegvesen.Models;
using Nadobe.Common.Interfaces;
using Nadobe.Common.Models;
using Nadobe.Common.Models.Enums;
using Newtonsoft.Json;
using NJsonSchema;

namespace Altinn.Dan.Plugin.Statensvegvesen;

public class Metadata : IEvidenceSourceMetadata
{
    public const string SOURCE = "Svv";

    public const int ERROR_NO_VEHICLES_FOUND = 1;

    public const int ERROR_CCR_UPSTREAM_ERROR = 2;

    public const int ERROR_BAD_REQUEST = 3;

    public List<EvidenceCode> GetEvidenceCodes()
    {
        return new List<EvidenceCode>
        {
            new()
            {
                EvidenceCodeName = "Kjoretoy",
                EvidenceSource = SOURCE,
                BelongsToServiceContexts = new List<string> { "OED" },
                RequiredScopes = "",
                Values = new List<EvidenceValue>
                {
                    new()
                    {
                        EvidenceValueName = "default",
                        ValueType = EvidenceValueType.JsonSchema,
                        JsonSchemaDefintion = JsonSchema.FromType<SvvResponse>().ToJson(Formatting.Indented)
                    }
                },
                AuthorizationRequirements = new List<Requirement>
                {
                    new MaskinportenScopeRequirement
                    {
                        RequiredScopes = new List<string> { "altinn:dataaltinnno/oed" }
                    }
                }
            }
        };
    }
}
