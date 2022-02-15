using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Altinn.Dan.Plugin.Statensvegvesen.Clients;
using Altinn.Dan.Plugin.Statensvegvesen.Test.TestUtils;
using Nadobe.Common.Exceptions;
using Xunit;

namespace Altinn.Dan.Plugin.Statensvegvesen.Test.Clients;

public class SvvClientTest
{
    [Fact]
    public async Task SokKjoretoyForFodselsnummer_BadRequest_Exception()
    {
        var httpClient = TestHelpers.GetHttpClientMock(HttpStatusCode.BadRequest);
        var client = new SvvClient(httpClient);

        var exception = await Assert.ThrowsAsync<EvidenceSourcePermanentClientException>(() => client.SokKjoretoyForFodselsnummer("123456789123"));

        Assert.Equal(Metadata.ERROR_BAD_REQUEST, exception.DetailErrorCode);
        Assert.Contains("Bad request", exception.Message);
    }

    [Fact]
    public async Task SokKjoretoyForFodselsnummer_NoContent_Exception()
    {
        var httpClient = TestHelpers.GetHttpClientMock(HttpStatusCode.NoContent);
        var client = new SvvClient(httpClient);

        var exception = await Assert.ThrowsAsync<EvidenceSourcePermanentClientException>(() => client.SokKjoretoyForFodselsnummer("123456789123"));

        Assert.Equal(Metadata.ERROR_NO_VEHICLES_FOUND, exception.DetailErrorCode);
        Assert.Contains("No vehicles found", exception.Message);
    }

    [Fact]
    public async Task SokKjoretoyForFodselsnummer_RequestFail_Exception()
    {
        var httpClient = TestHelpers.GetHttpClientExceptionMock();
        var client = new SvvClient(httpClient);

        var exception = await Assert.ThrowsAsync<EvidenceSourcePermanentServerException>(() => client.SokKjoretoyForFodselsnummer("123456789123"));

        Assert.Equal(Metadata.ERROR_CCR_UPSTREAM_ERROR, exception.DetailErrorCode);
        Assert.Contains("Connection refused", exception.InnerException!.Message);
    }

    [Fact]
    public async Task SokKjoretoyForFodselsnummer_NoArguments_Exception()
    {
        var client = new SvvClient(new HttpClient());

        var exception = await Assert.ThrowsAsync<EvidenceSourcePermanentClientException>(() => client.SokKjoretoyForFodselsnummer(null));

        Assert.Equal(Metadata.ERROR_BAD_REQUEST, exception.DetailErrorCode);
        Assert.Contains("argument cannot be empty", exception.Message);
    }
}
