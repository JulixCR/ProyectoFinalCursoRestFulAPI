using ProyectoFinal.ET;

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

        public async Task<Indicadores?> ConsultarIndicadorEconomico()
        {
            Indicadores? indicadoresHacienda = new Indicadores();

            var responseSituacion = await _httpClient.GetAsync($"indicadores/tc");

            if (responseSituacion.IsSuccessStatusCode)
            {
                indicadoresHacienda = await responseSituacion.Content.ReadFromJsonAsync<Indicadores>();
            }

            return indicadoresHacienda;
        }

        public async Task<Exoneracion?> ConsultarExoneracion(string autorizacion)
        {
            Exoneracion? exoneracionHacienda = new Exoneracion();

            var responseSituacion = await _httpClient.GetAsync($"fe/ex?autorizacion={autorizacion}");

            if (responseSituacion.IsSuccessStatusCode)
            {
                exoneracionHacienda = await responseSituacion.Content.ReadFromJsonAsync<Exoneracion>();
            }

            return exoneracionHacienda;
        }

        public async Task<Agropecuario?> ConsultarProductorAgropecuario(string identificacion)
        {
            Agropecuario? situacionHacienda = new Agropecuario();

            var responseSituacion = await _httpClient.GetAsync($"fe/agropecuario?identificacion={identificacion}");

            if (responseSituacion.IsSuccessStatusCode)
            {
                situacionHacienda = await responseSituacion.Content.ReadFromJsonAsync<Agropecuario>();
            }

            return situacionHacienda;
        }

        public async Task<CodigoCabys?> ConsultarCabys(string codigoConsultar)
        {
            CodigoCabys? situacionHacienda = new CodigoCabys();

            var responseSituacion = await _httpClient.GetAsync($"fe/cabys?q={codigoConsultar}");

            if (responseSituacion.IsSuccessStatusCode)
            {
                situacionHacienda = await responseSituacion.Content.ReadFromJsonAsync<CodigoCabys>();
            }

            return situacionHacienda;
        }
    }
}
