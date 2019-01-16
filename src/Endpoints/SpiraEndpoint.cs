using System.Threading.Tasks;
using SpiraAPI.Client.Connection;

namespace SpiraAPI.Client.Endpoints
{
    internal abstract class SpiraEndpoint
    {
        protected ISpiraConnection Connection { get; }
        protected abstract string EndpointUrl { get; }

        protected SpiraEndpoint(ISpiraConnection connection) => Connection = connection;

        protected TOutput Get<TOutput>(string relativeUrl)
        {
            var endpoint = GetEndpoint(relativeUrl);
            return Connection.Get<TOutput>(endpoint);
        }

        protected Task<TOutput> GetAsync<TOutput>(string relativeUrl)
        {
            var endpoint = GetEndpoint(relativeUrl);
            return Connection.GetAsync<TOutput>(endpoint);
        }

        protected TOutput Post<TInput, TOutput>(string relativeUrl, TInput data)
        {
            var endpoint = GetEndpoint(relativeUrl);
            return Connection.Post<TInput, TOutput>(endpoint, data);
        }

        protected Task<TOutput> PostAsync<TInput, TOutput>(string relativeUrl, TInput data)
        {
            var endpoint = GetEndpoint(relativeUrl);
            return Connection.PostAsync<TInput,TOutput>(endpoint, data);
        }

        private string GetEndpoint(string relativeUrl)
        {
            return $"{Connection.ServiceUrl}/{EndpointUrl}/{relativeUrl}";
        }
    }
}
