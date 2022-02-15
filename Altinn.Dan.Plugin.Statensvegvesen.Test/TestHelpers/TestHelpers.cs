using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Altinn.Dan.Plugin.Statensvegvesen.Clients;
using Microsoft.AspNetCore.Http.Internal;
using Moq;
using Moq.Protected;
using Newtonsoft.Json;

namespace Altinn.Dan.Plugin.Statensvegvesen.Test.TestUtils
{
    public static class TestHelpers
    {
        public static HttpClient GetHttpClientMock(HttpStatusCode httpStatusCode = HttpStatusCode.OK, string responseBody = "")
        {
            var handler = new Mock<HttpMessageHandler>();
            handler.Protected()
                .Setup<Task<HttpResponseMessage>>("SendAsync", ItExpr.IsAny<HttpRequestMessage>(), ItExpr.IsAny<CancellationToken>())
                .ReturnsAsync(new HttpResponseMessage
                    {
                        StatusCode = httpStatusCode,
                        Content = new StringContent(responseBody)
                    }
                );
            var httpClient = new HttpClient(handler.Object);
            httpClient.BaseAddress = new Uri("http://localhost");

            return httpClient;
        }

        public static HttpClient GetHttpClientExceptionMock()
        {
            var handler = new Mock<HttpMessageHandler>();
            handler.Protected()
                .Setup<Task<HttpResponseMessage>>("SendAsync", ItExpr.IsAny<HttpRequestMessage>(), ItExpr.IsAny<CancellationToken>())
                .Throws(new HttpRequestException("Connection refused"));
            var httpClient = new HttpClient(handler.Object);
            httpClient.BaseAddress = new Uri("http://localhost");

            return httpClient;
        }

        public static T LoadJson<T>(string filename)
        {
            using (var reader = new StreamReader("TestResources" + Path.DirectorySeparatorChar + filename))
            {
                return JsonConvert.DeserializeObject<T>(reader.ReadToEnd());
            }
        }
    }
}
