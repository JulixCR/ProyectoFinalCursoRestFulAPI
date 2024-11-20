using ProyectoFinal.API.Entities;

namespace ProyectoFinal.API.Services
{
    public class HaciendaServices : IHaciendaServices
    {
        private readonly HttpClient _httpClient;


        public HaciendaServices(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient("HaciendaAPI");
        }

        public async Task<SituacionTributaria?> ConsultarSituacionTributaria()
        {
            SituacionTributaria? situacionHacienda = new SituacionTributaria();

            var responseSituacion = await _httpClient.GetAsync("ae");
            
            if (responseSituacion.IsSuccessStatusCode)
            {
                situacionHacienda = await responseSituacion.Content.ReadFromJsonAsync<SituacionTributaria>();
            }

            return situacionHacienda;
        }

        public async Task<string> ConsultarIndicadorEconomico()
        {

            var responseString = await _httpClient.GetStringAsync("author");


            Console.WriteLine(responseString);

            return responseString;
        }
    }
}
