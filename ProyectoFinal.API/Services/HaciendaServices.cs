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

        public async Task<SituacionTributaria?> ConsultarSituacionTributaria(string identificacion)
        {
            SituacionTributaria? situacionHacienda = new SituacionTributaria();

            var responseSituacion = await _httpClient.GetAsync($"fe/ae?identificacion={identificacion}");

            if (responseSituacion.IsSuccessStatusCode)
            {
                situacionHacienda = await responseSituacion.Content.ReadFromJsonAsync<SituacionTributaria>();
            }
             
            return situacionHacienda;
        }

        public async Task<string> ConsultarIndicadorEconomico()
        {

            var responseString = await _httpClient.GetStringAsync("indicadores/tc"); //requiere crear una entidad nueva 


            Console.WriteLine(responseString);

            return responseString;
        }

        public async Task<SituacionTributaria?> ConsultarExoneracion(string autorizacion)
        {
            SituacionTributaria? situacionHacienda = new SituacionTributaria(); //utilizar otra entidad para exportacion

            var responseSituacion = await _httpClient.GetAsync($"fe/ex?autorizacion={autorizacion}");

            if (responseSituacion.IsSuccessStatusCode)
            {
                situacionHacienda = await responseSituacion.Content.ReadFromJsonAsync<SituacionTributaria>();
            }

            return situacionHacienda;
        }

        public async Task<SituacionTributaria?> ConsultarProductorAgropecuario(string identificacion)
        {
            SituacionTributaria? situacionHacienda = new SituacionTributaria(); //utilizar otra entidad para exportacion

            var responseSituacion = await _httpClient.GetAsync($"fe/agropecuario?identificacion={identificacion}");

            if (responseSituacion.IsSuccessStatusCode)
            {
                situacionHacienda = await responseSituacion.Content.ReadFromJsonAsync<SituacionTributaria>();
            }

            return situacionHacienda;
        }

        public async Task<SituacionTributaria?> ConsultarCabys(string codigoConsultar)
        {
            SituacionTributaria? situacionHacienda = new SituacionTributaria(); //utilizar otra entidad para cabys

            var responseSituacion = await _httpClient.GetAsync($"fe/cabys?q={codigoConsultar}");

            if (responseSituacion.IsSuccessStatusCode)
            {
                situacionHacienda = await responseSituacion.Content.ReadFromJsonAsync<SituacionTributaria>();
            }

            return situacionHacienda;
        }
    }
}
