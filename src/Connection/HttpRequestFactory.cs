using System.Net.Http;
using System.Text;
using Newtonsoft.Json;

namespace SpiraAPI.Client.Connection
{
    internal static class HttpRequestFactory
    {
        public static HttpRequestMessage Get(string endpoint) =>
            CreateRequest<object>(endpoint, HttpMethod.Get);
        public static HttpRequestMessage Post<TInput>(string endpoint, TInput data) =>
            CreateRequest(endpoint, HttpMethod.Post, data);

        private static HttpRequestMessage CreateRequest<TInput>(
            string endpoint,
            HttpMethod method,
            TInput data = default)
        {
            var request = new HttpRequestMessage(method, endpoint);

            if (data != null &&
                (method == HttpMethod.Post || method == HttpMethod.Put))
            {
                var body = JsonConvert.SerializeObject(data);
                request.Content = new StringContent(body, Encoding.UTF8, "application/json");
            }

            return request;
        }
    }
}
