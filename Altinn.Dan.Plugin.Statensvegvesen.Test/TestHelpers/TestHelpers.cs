using Moq;
using Moq.Protected;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

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

        public static string LoadJson(string filename)
        {
            using (var r = new StreamReader("TestResources" + Path.DirectorySeparatorChar + filename))
            {
                return r.ReadToEnd();
            }
        }

        public static T LoadJson<T>(string filename)
        {
            return JsonConvert.DeserializeObject<T>(LoadJson(filename));
        }
    }
}
