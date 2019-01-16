using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SpiraAPI.Client.Middleware;

namespace SpiraAPI.Client.Connection
{
    public class SpiraConnection : ISpiraConnection
    {
        private static TokenGenerator _generator;
        private static HttpClient _httpClient;

        public string ServiceUrl { get; }

        static SpiraConnection()
        {
            var handler = new HttpClientHandler();
            _httpClient = new HttpClient(handler);
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/josn"));
        }

        public SpiraConnection(string serviceUrl, ISpiraCredentials credentials)
        {
            ServiceUrl = serviceUrl.Trim('/');
            _generator = new TokenGenerator(credentials);
        }

        public TOutput Get<TOutput>(string endpoint)
        {
            var request = HttpRequestFactory.Get(endpoint);
            return Send<TOutput>(request);
        }

        public Task<TOutput> GetAsync<TOutput>(string endpoint)
        {
            var request = HttpRequestFactory.Get(endpoint);
            return SendAsync<TOutput>(request);
        }

        public TOutput Post<TInput, TOutput>(string endpoint, TInput data)
        {
            var request = HttpRequestFactory.Post(endpoint, data);
            return Send<TOutput>(request);
        }

        public Task<TOutput> PostAsync<TInput, TOutput>(string endpoint, TInput data)
        {
            var request = HttpRequestFactory.Post(endpoint, data);
            return SendAsync<TOutput>(request);
        }

        private TOutput Send<TOutput>(HttpRequestMessage request)
        {
            SetHeaders(request.Headers);

            var response = _httpClient.SendAsync(request).Result;
            var content = response.EnsureSuccessStatusCode().Content.ReadAsStringAsync().Result;

            return JsonConvert.DeserializeObject<TOutput>(content);
        }

        private async Task<TOutput> SendAsync<TOutput>(HttpRequestMessage request)
        {
            SetHeaders(request.Headers);

            var response = await _httpClient.SendAsync(request).ConfigureAwait(false);
            var content = await response.EnsureSuccessStatusCode().Content.ReadAsStringAsync().ConfigureAwait(false);

            return JsonConvert.DeserializeObject<TOutput>(content);
        }

        private void SetHeaders(HttpRequestHeaders headers)
        {
            headers.Authorization = new AuthenticationHeaderValue("Basic", _generator.GetToken());
        }
    }
}