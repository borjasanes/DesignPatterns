using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Structural.Proxy
{
    /// <summary>
    /// Provide a placeholder for another object to control access to it.
    /// </summary>
    public class ContactsProxy
    {
        private readonly string _apiKey;
        private static readonly HttpClient HttpClient = new HttpClient();

        public ContactsProxy(string host, string apiKey)
        {
            _apiKey = apiKey;
            HttpClient.BaseAddress = new Uri(host);
        }

        public async Task<string> GetContactName(string email)
        {
            HttpClient.DefaultRequestHeaders.Authorization = GetAuthenticationHeaderValue();

            return await HttpClient.GetStringAsync($"/contact/{email}");
        }

        private AuthenticationHeaderValue GetAuthenticationHeaderValue()
        {
            return new AuthenticationHeaderValue(_apiKey);
        }
    }
}
