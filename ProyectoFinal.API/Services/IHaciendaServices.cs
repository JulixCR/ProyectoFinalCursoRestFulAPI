using ProyectoFinal.ET;

namespace ProyectoFinal.API.Services
{
    public interface IHaciendaServices
    {
        Task<SituacionTributaria?> ConsultarSituacionTributaria(string identificacion);
        Task<Indicadores?> ConsultarIndicadorEconomico();
        Task<Exoneracion?> ConsultarExoneracion(string autorizacion);
        Task<Agropecuario?> ConsultarProductorAgropecuario(string identificacion);
        Task<CodigoCabys?> ConsultarCabys(string codigoConsultar);
    }
}
