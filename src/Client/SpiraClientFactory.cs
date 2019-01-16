using SpiraAPI.Client.Connection;
using SpiraAPI.Client.Middleware;

namespace SpiraAPI.Client.Client
{
    public interface ISpiraClientFactory
    {
        ISpiraClient Create(ISpiraCredentials credentials);
    }

    public sealed class SpiraClientFactory
    {
        private readonly string _endpoint;

        public SpiraClientFactory(string endpoint)
        {
            _endpoint = endpoint;
        }

        public ISpiraClient Create(ISpiraCredentials credentials)
        {
            var connection = new SpiraConnection(_endpoint, credentials);
            return new SpiraClient(connection);
        }
    }
}
