using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using Altinn.Dan.Plugin.Statensvegvesen.Clients;
using Altinn.Dan.Plugin.Statensvegvesen.Utils;
using Azure.Core.Serialization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;
using Nadobe;
using Nadobe.Common.Models;
using Nadobe.Common.Util;
using Newtonsoft.Json;

namespace Altinn.Dan.Plugin.Statensvegvesen;

public class Main
{
    private ILogger _logger;
    private readonly SvvClient _svvClient;

    public Main(SvvClient svvClient)
    {
        _svvClient = svvClient;
    }

    [Function("Kjoretoy")]
    public async Task<HttpResponseData> Kjoretoy(
        [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)] HttpRequestData req,
        FunctionContext context)
    {
        _logger = context.GetLogger(context.FunctionDefinition.Name);
        _logger.LogInformation("Running func 'Kjoretoy'");
        var requestBody = await new StreamReader(req.Body).ReadToEndAsync();
        var evidenceHarvesterRequest = JsonConvert.DeserializeObject<EvidenceHarvesterRequest>(requestBody);

        var actionResult = await EvidenceSourceResponse.CreateResponse(null, () => GetEvidenceValuesKjoretoy(evidenceHarvesterRequest)) as ObjectResult;
        var response = req.CreateResponse(HttpStatusCode.OK);
        await response.WriteAsJsonAsync(actionResult?.Value);

        return response;
    }

    private async Task<List<EvidenceValue>> GetEvidenceValuesKjoretoy(EvidenceHarvesterRequest evidenceHarvesterRequest)
    {
        var svvResponse = OedUtils.MapToInternal(await _svvClient.SokKjoretoyForFodselsnummer(evidenceHarvesterRequest.OrganizationNumber));

        var ecb = new EvidenceBuilder(new Metadata(), "Kjoretoy");
        ecb.AddEvidenceValue("default", JsonConvert.SerializeObject(svvResponse), Metadata.SOURCE);

        return ecb.GetEvidenceValues();
    }

    [Function(Constants.EvidenceSourceMetadataFunctionName)]
    public async Task<HttpResponseData> GetMetadata(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)] HttpRequestData req,
        FunctionContext context)
    {
        _logger = context.GetLogger(context.FunctionDefinition.Name);
        _logger.LogInformation($"Running func metadata for {Constants.EvidenceSourceMetadataFunctionName}");
        var response = req.CreateResponse(HttpStatusCode.OK);
        await response.WriteAsJsonAsync(new Metadata().GetEvidenceCodes(),
            new NewtonsoftJsonObjectSerializer(new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto }));

        return response;
    }
}
