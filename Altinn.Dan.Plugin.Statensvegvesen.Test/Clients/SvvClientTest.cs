using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Altinn.Dan.Plugin.Statensvegvesen.Clients;
using Altinn.Dan.Plugin.Statensvegvesen.Test.TestUtils;
using Moq;
using Nadobe.Common.Exceptions;
using Xunit;

namespace Altinn.Dan.Plugin.Statensvegvesen.Test.Clients;

public class SvvClientTest
{
    private readonly Mock<IHttpClientFactory> _httpClientFactory = new Mock<IHttpClientFactory>();

    [Fact]
    public async Task SokKjoretoyForFodselsnummer_ok()
    {
        var kjoretoysokResponse = TestHelpers.LoadJson("KjoretoysokResponse_from_svv.json");
        var httpClient = TestHelpers.GetHttpClientMock(HttpStatusCode.OK, kjoretoysokResponse);
        _httpClientFactory.Setup(_ => _.CreateClient(It.IsAny<string>())).Returns(httpClient);
        var client = new SvvClient(_httpClientFactory.Object);

        var actual = await client.SokKjoretoyForFodselsnummer("123456789123");

        Assert.Equal(2, actual.Kjoretoyresponser.Count);
    }

    [Fact]
    public async Task SokKjoretoyForFodselsnummer_NoContent_ReturnsNull()
    {
        var httpClient = TestHelpers.GetHttpClientMock(HttpStatusCode.NoContent);
        _httpClientFactory.Setup(_ => _.CreateClient(It.IsAny<string>())).Returns(httpClient);
        var client = new SvvClient(_httpClientFactory.Object);

        var actual = await client.SokKjoretoyForFodselsnummer("123456789123");

        Assert.Null(actual);
    }

    [Fact]
    public async Task SokKjoretoyForFodselsnummer_BadRequest_Exception()
    {
        var httpClient = TestHelpers.GetHttpClientMock(HttpStatusCode.BadRequest);
        _httpClientFactory.Setup(_ => _.CreateClient(It.IsAny<string>())).Returns(httpClient);
        var client = new SvvClient(_httpClientFactory.Object);

        var exception = await Assert.ThrowsAsync<EvidenceSourcePermanentClientException>(() => client.SokKjoretoyForFodselsnummer("123456789123"));

        Assert.Equal(Metadata.ERROR_BAD_REQUEST, exception.DetailErrorCode);
        Assert.Contains("Bad request", exception.Message);
    }

    [Fact]
    public async Task SokKjoretoyForFodselsnummer_RequestFail_Exception()
    {
        var httpClient = TestHelpers.GetHttpClientExceptionMock();
        _httpClientFactory.Setup(_ => _.CreateClient(It.IsAny<string>())).Returns(httpClient);
        var client = new SvvClient(_httpClientFactory.Object);

        var exception = await Assert.ThrowsAsync<EvidenceSourcePermanentServerException>(() => client.SokKjoretoyForFodselsnummer("123456789123"));

        Assert.Equal(Metadata.ERROR_CCR_UPSTREAM_ERROR, exception.DetailErrorCode);
        Assert.Contains("Connection refused", exception.InnerException!.Message);
    }

    [Fact]
    public async Task SokKjoretoyForFodselsnummer_NoArguments_Exception()
    {
        var client = new SvvClient(new Mock<IHttpClientFactory>().Object);

        var exception = await Assert.ThrowsAsync<EvidenceSourcePermanentClientException>(() => client.SokKjoretoyForFodselsnummer(null));

        Assert.Equal(Metadata.ERROR_BAD_REQUEST, exception.DetailErrorCode);
        Assert.Contains("argument cannot be empty", exception.Message);
    }
}
