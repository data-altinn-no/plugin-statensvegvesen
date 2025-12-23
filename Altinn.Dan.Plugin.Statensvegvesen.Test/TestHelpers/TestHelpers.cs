using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using FakeItEasy;
using Newtonsoft.Json;

namespace Altinn.Dan.Plugin.Statensvegvesen.Test.TestUtils
{
    public static class TestHelpers
    {
        // Derived class to allow faking the protected SendAsync
        public class TestHttpMessageHandler : HttpMessageHandler
        {
            public virtual Task<HttpResponseMessage> SendAsyncPublic(HttpRequestMessage request, CancellationToken cancellationToken)
            {
                return SendAsync(request, cancellationToken);
            }

            protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
            {
                // Default implementation
                return Task.FromResult(new HttpResponseMessage(HttpStatusCode.OK));
            }
        }

        public static HttpClient GetHttpClientMock(HttpStatusCode httpStatusCode = HttpStatusCode.OK, string responseBody = "")
        {
            var handler = A.Fake<TestHttpMessageHandler>();

            // Configure the fake to return the response
            A.CallTo(() => handler.SendAsyncPublic(A<HttpRequestMessage>._, A<CancellationToken>._))
                .Returns(Task.FromResult(new HttpResponseMessage
                {
                    StatusCode = httpStatusCode,
                    Content = new StringContent(responseBody)
                }));

            var httpClient = new HttpClient(handler);
            httpClient.BaseAddress = new Uri("http://localhost");

            return httpClient;
        }

        public static HttpClient GetHttpClientExceptionMock()
        {
            var handler = A.Fake<TestHttpMessageHandler>();

            // Configure the fake to throw an exception
            A.CallTo(() => handler.SendAsyncPublic(A<HttpRequestMessage>._, A<CancellationToken>._))
                .Throws(new HttpRequestException("Connection refused"));

            var httpClient = new HttpClient(handler);
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
