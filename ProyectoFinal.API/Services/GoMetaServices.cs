using ProyectoFinal.ET;
using Newtonsoft.Json;

namespace ProyectoFinal.API.Services
{
    public class GoMetaServices : IGoMetaServices
    {
        private readonly HttpClient _httpClient;

        public GoMetaServices(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient("GoMetaAPI");
        }

        public async Task<StatusAPI?> StatusAPIHacienda()
        {
            StatusAPI? StatusGoMeta = new StatusAPI();

            var responseSituacion = await _httpClient.GetAsync("status/status.json");

            if (responseSituacion.IsSuccessStatusCode)
            {
                StatusGoMeta = await responseSituacion.Content.ReadFromJsonAsync<StatusAPI>();
            }
             
            return StatusGoMeta;
        }
    }
}
