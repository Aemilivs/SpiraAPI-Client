using SpiraAPI.Client.Middleware;
using static System.Text.Encoding;
using Convert = System.Convert;

namespace SpiraAPI.Client.Connection
{
    internal sealed class TokenGenerator
    {
        private readonly ISpiraCredentials _credentials;
        private readonly string _token;
        public TokenGenerator(ISpiraCredentials credentials)
        {
            _credentials = credentials;
            _token = CreateToken();
        }

        private string CreateToken()
        {
            var resource = $"{_credentials.Username}:{{{_credentials.RsaToken}}}";
            var bytes = ASCII.GetBytes(resource);
            var result = Convert.ToBase64String(bytes);
            return result;
        }

        public string GetToken() => _token;
    }
}