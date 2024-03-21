using Altinn.Dan.Plugin.Statensvegvesen.Models;
using Dan.Common.Enums;
using Dan.Common.Interfaces;
using Dan.Common.Models;
using Newtonsoft.Json;
using NJsonSchema;
using System.Collections.Generic;

namespace Altinn.Dan.Plugin.Statensvegvesen;

public class Metadata : IEvidenceSourceMetadata
{
    public const string SOURCE = "Statens vegvesen";
    public const string ebevis = "eBevis";
    public const string oed = "OED";
    public const string EDUEDILIGENCE = "eDueDiligence";

    public const int ERROR_NO_VEHICLES_FOUND = 1;

    public const int ERROR_CCR_UPSTREAM_ERROR = 2;

    public const int ERROR_BAD_REQUEST = 3;

    public const int ERROR_QUOTA_EXCEEDED = 4;

    public List<EvidenceCode> GetEvidenceCodes()
    {
        return new List<EvidenceCode>
        {
            new()
            {
                EvidenceCodeName = "Kjoretoy",
                EvidenceSource = SOURCE,
                BelongsToServiceContexts = new List<string> { oed },
                RequiredScopes = "",
                Values = new List<EvidenceValue>
                {
                    new()
                    {
                        EvidenceValueName = "default",
                        ValueType = EvidenceValueType.JsonSchema,
                        JsonSchemaDefintion = JsonSchema.FromType<SvvResponse>().ToJson(Formatting.Indented),
                        Source = SOURCE
                    }
                },
                AuthorizationRequirements = new List<Requirement>
                {
                    new MaskinportenScopeRequirement
                    {
                        RequiredScopes = new List<string> { "altinn:dataaltinnno/oed" }
                    }
                }
            },
            new()
            {
                EvidenceCodeName = "Kjoretoyopplysninger",
                EvidenceSource = SOURCE,
                BelongsToServiceContexts = new List<string> { EDUEDILIGENCE },
                RequiredScopes = "",
                Values = new List<EvidenceValue>
                {
                    new()
                    {
                        EvidenceValueName = "default",
                        ValueType = EvidenceValueType.JsonSchema,
                        JsonSchemaDefintion = JsonSchema.FromType<SvvResponse>().ToJson(Formatting.Indented),
                        Source = SOURCE
                    }
                },
                AuthorizationRequirements = new List<Requirement>
                {
                    new MaskinportenScopeRequirement
                    {
                        RequiredScopes = new List<string> { "altinn:dataaltinnno/eduediligence" }
                    }
                }
            },
            new()
            {
                EvidenceCodeName = "Verkstedregisteret",
                EvidenceSource = SOURCE,
                BelongsToServiceContexts = new List<string> { ebevis },
                Values = new List<EvidenceValue>
                {
                    new()
                    {
                        EvidenceValueName = "organisasjonsnummer",
                        ValueType = EvidenceValueType.String,
                        Source = SOURCE
                    },
                    new()
                    {
                        EvidenceValueName = "godkjenningstyper",
                        ValueType = EvidenceValueType.String,
                        Source = SOURCE
                    },
                    new()
                    {
                        EvidenceValueName = "godkjenningsnumre",
                        ValueType = EvidenceValueType.String,
                        Source = SOURCE
                    }
                }
            }
        };
    }
}
