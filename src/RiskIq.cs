using Polly;
using Polly.Retry;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace RiskIqSharp
{
    public class RiskIq
    {
        private string _userName;
        private string _apiKey;
        private HttpClient _httpClient;

        private const string BASE_URL = "https://api.riskiq.net/pt/v2/";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="apiKey"></param>
        public RiskIq(string userName, string apiKey)
        {
            _userName = userName;
            _apiKey = apiKey;

            CreateHttpClient();
        }

        /// <summary>
        /// 
        /// </summary>
        private void CreateHttpClient()
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var authToken = Encoding.ASCII.GetBytes($"{_userName}:{_apiKey}");
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(authToken));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="api"></param>
        /// <param name="lookup"></param>
        /// <returns></returns>
        private Uri GetApiUri(string api, string lookup)
        {
            return new Uri(BASE_URL + $"{api}?query={lookup}");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private static AsyncRetryPolicy GetRetryPolicy()
        {
            return Policy.Handle<Exception>()
                .WaitAndRetryAsync(3, retryCount => TimeSpan.FromSeconds(1),
                    onRetry: (response, exception, retryCount, context) =>
                    {
                        Console.WriteLine($"{response.GetType()} thrown, retrying {retryCount}.");
                    });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lookup"></param>
        /// <returns></returns>
        public async Task<string> ReputationAsString(string lookup)
        {
            var retryPolicy = GetRetryPolicy();
            string ret = await retryPolicy.ExecuteAsync(() =>
            {
                HttpResponseMessage response = _httpClient.GetAsync(GetApiUri("reputation", lookup)).Result;
                if (response.IsSuccessStatusCode == true)
                {
                    return response.Content.ReadAsStringAsync();
                }

                return null;

            }).ConfigureAwait(false);

            return ret;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lookup"></param>
        /// <returns></returns>
        public async Task<Reputation> Reputation(string lookup)
        {
            var retryPolicy = GetRetryPolicy();
            Reputation ret = await retryPolicy.ExecuteAsync(() =>
            {
                HttpResponseMessage response = _httpClient.GetAsync(GetApiUri("reputation", lookup)).Result;
                if (response.IsSuccessStatusCode == true)
                {
                    var content = response.Content.ReadAsStringAsync().Result;

                    Reputation r = new Reputation();
                    if (r.Parse(content) == true)
                    {
                        return Task.FromResult(r);
                    }

                    return null;
                }

                return null;

            }).ConfigureAwait(false);

            return ret;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lookup"></param>
        /// <returns></returns>
        public async Task<string> WhoisAsString(string lookup)
        {
            var retryPolicy = GetRetryPolicy();
            string ret = await retryPolicy.ExecuteAsync(() =>
            {
                HttpResponseMessage response = _httpClient.GetAsync(GetApiUri("whois", lookup)).Result;
                if (response.IsSuccessStatusCode == true)
                {
                    return response.Content.ReadAsStringAsync();
                }

                return null;

            }).ConfigureAwait(false);

            return ret;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lookup"></param>
        /// <returns></returns>
        public async Task<WhoIs> Whois(string lookup)
        {
            var retryPolicy = GetRetryPolicy();
            WhoIs ret = await retryPolicy.ExecuteAsync(() =>
            {
                HttpResponseMessage response = _httpClient.GetAsync(GetApiUri("whois", lookup)).Result;
                if (response.IsSuccessStatusCode == true)
                {
                    var content = response.Content.ReadAsStringAsync().Result;

                    WhoIs w = new WhoIs();
                    if (w.Parse(content) == true)
                    {
                        return Task.FromResult(w);
                    }

                    return null;
                }

                return null;

            }).ConfigureAwait(false);

            return ret;
        }
    }
}
