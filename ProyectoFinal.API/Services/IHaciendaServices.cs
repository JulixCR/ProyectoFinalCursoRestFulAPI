using ProyectoFinal.API.Entities;

namespace ProyectoFinal.API.Services
{
    public interface IHaciendaServices
    {
        Task<SituacionTributaria?> ConsultarSituacionTributaria();
        Task<string> ConsultarIndicadorEconomico();
    }
}
