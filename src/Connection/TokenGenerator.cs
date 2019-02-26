using SpiraAPI.Client.Middleware;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
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
            var rsaToken = FormatRsaToken(_credentials.RsaToken);
            var resource = $"{_credentials.Username}:{rsaToken}";
            var bytes = ASCII.GetBytes(resource);
            var result = Convert.ToBase64String(bytes);
            return result;
        }

        private string FormatRsaToken(string token)
        {
            if (token.StartsWith("{") ||
                token.EndsWith("}"))
                return token;

            var result = $"{{{token}}}";

            return result;
        }

        public string GetToken() => _token;
    }
}