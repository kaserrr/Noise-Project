using Noise.Contracts;
using RestSharp;

namespace BlazorConfig.Api
{
    public class ApiClient
    {
        private RestClient _client;

        public ApiClient(HttpClient httpClient)
        {
            _client = new RestClient(httpClient);
        }

        public async Task<IEnumerable<Models>> GetModels()
        {
            var response = await _client.GetJsonAsync<IEnumerable<Models>>(resource: "https://localhost:7046/swagger/v1/swagger.json");
            return response;
        }
    }
}
