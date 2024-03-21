using Altinn.Dan.Plugin.Statensvegvesen.Clients;
using Altinn.Dan.Plugin.Statensvegvesen.Utils;
using Azure.Core.Serialization;
using Dan.Common;
using Dan.Common.Models;
using Dan.Common.Util;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Altinn.Dan.Plugin.Statensvegvesen;

public class Main
{
    private ILogger _logger;
    private readonly SvvClient _svvClient;

    public Main(SvvClient svvClient, ILoggerFactory loggerFactory)
    {
        _svvClient = svvClient;
        _logger = loggerFactory.CreateLogger<Main>();
    }

    [Function("Kjoretoy")]
    public async Task<HttpResponseData> Kjoretoy(
        [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)] HttpRequestData req,
        FunctionContext context)
    {
        _logger.LogInformation("Running func 'Kjoretoy'");
        var requestBody = await new StreamReader(req.Body).ReadToEndAsync();
        var evidenceHarvesterRequest = JsonConvert.DeserializeObject<EvidenceHarvesterRequest>(requestBody);

        return await EvidenceSourceResponse.CreateResponse(req, () => GetEvidenceValuesKjoretoy(evidenceHarvesterRequest));
    }

    private async Task<List<EvidenceValue>> GetEvidenceValuesKjoretoy(EvidenceHarvesterRequest evidenceHarvesterRequest)
    {
        var subject = evidenceHarvesterRequest.SubjectParty;
        try
        {
            var svvResponse = OedUtils.MapToInternal(await _svvClient.SokKjoretoyForFodselsnummer(subject?.NorwegianSocialSecurityNumber));

            var ecb = new EvidenceBuilder(new Metadata(), "Kjoretoy");
            ecb.AddEvidenceValue("default", JsonConvert.SerializeObject(svvResponse), Metadata.SOURCE, false);

            return ecb.GetEvidenceValues();
        }
        catch (Exception e)
        {
            _logger.LogError($"Func 'Kjoretoy' failed for input '{(subject?.NorwegianSocialSecurityNumber.Length < 6 ? subject.NorwegianSocialSecurityNumber : subject?.GetAsString())}': {e.Message}");

            throw;
        }
    }

    [Function("Kjoretoyopplysninger")]
    public async Task<HttpResponseData> Kjoretoyopplysninger(
        [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)] HttpRequestData req,
        FunctionContext context)
    {
        _logger.LogInformation("Running func 'Kjoretoy'");
        var requestBody = await new StreamReader(req.Body).ReadToEndAsync();
        var evidenceHarvesterRequest = JsonConvert.DeserializeObject<EvidenceHarvesterRequest>(requestBody);

        return await EvidenceSourceResponse.CreateResponse(req, () => GetEvidenceValuesKjoretoyopplysninger(evidenceHarvesterRequest));
    }

    private async Task<List<EvidenceValue>> GetEvidenceValuesKjoretoyopplysninger(EvidenceHarvesterRequest evidenceHarvesterRequest)
    {
        var subject = evidenceHarvesterRequest.SubjectParty;
        try
        {
            var svvResponse = await _svvClient.SokKjoretoyForOrgnummer(subject?.NorwegianOrganizationNumber);

            var ecb = new EvidenceBuilder(new Metadata(), "Kjoretoyopplysninger");
            ecb.AddEvidenceValue("default", JsonConvert.SerializeObject(svvResponse), Metadata.SOURCE, false);

            return ecb.GetEvidenceValues();
        }
        catch (Exception e)
        {
            _logger.LogError($"Func 'Kjoretoy' failed for input '{subject?.NorwegianOrganizationNumber}': {e.Message}");

            throw;
        }
    }

    [Function("Verkstedregisteret")]
    public async Task<HttpResponseData> Verkstedregisteret(
        [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)] HttpRequestData req,
        FunctionContext context)
    {
        _logger.LogInformation("Running func 'Verkstedregisteret'");
        var requestBody = await new StreamReader(req.Body).ReadToEndAsync();
        var evidenceHarvesterRequest = JsonConvert.DeserializeObject<EvidenceHarvesterRequest>(requestBody);

        return await EvidenceSourceResponse.CreateResponse(req, () => GetEvidenceValuesVerksted(evidenceHarvesterRequest));
    }

    private async Task<List<EvidenceValue>> GetEvidenceValuesVerksted(EvidenceHarvesterRequest evidenceHarvesterRequest)
    {
        try
        {
            var ecb = new EvidenceBuilder(new Metadata(), "Verkstedregisteret");

            var registerOutput = await _svvClient.GetVerkstedRegister(evidenceHarvesterRequest.SubjectParty.NorwegianOrganizationNumber);

            var approvals = string.Join(", ", registerOutput.SelectMany(x => x.godkjenninger).Select(x => x.godkjenningsType));
            var allApprovalNumbers = string.Join(", ", registerOutput.Select(x => x.godkjenningsnr.ToString()));
            ecb.AddEvidenceValue("organisasjonsnummer", registerOutput.FirstOrDefault()?.organisasjonsnr, Metadata.SOURCE);
            ecb.AddEvidenceValue("godkjenningstyper", approvals, Metadata.SOURCE);
            ecb.AddEvidenceValue("godkjenningsnumre", allApprovalNumbers, Metadata.SOURCE);
            return ecb.GetEvidenceValues();
        } 
        catch (Exception ex)
        {
            _logger.LogError(ex.Message);
            throw;
        }
    }

    [Function(Constants.EvidenceSourceMetadataFunctionName)]
    public async Task<HttpResponseData> GetMetadata(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)] HttpRequestData req,
        FunctionContext context)
    {
        _logger.LogInformation($"Running func metadata for {Constants.EvidenceSourceMetadataFunctionName}");
        var response = req.CreateResponse(HttpStatusCode.OK);
        await response.WriteAsJsonAsync(new Metadata().GetEvidenceCodes(),
            new NewtonsoftJsonObjectSerializer(new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto }));

        return response;
    }
}
