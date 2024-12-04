using ProyectoFinal.ET;
using System.Threading.Tasks;

namespace ProyectoFinal.DS
{
    public interface IBitacoraRepository
    {
        bool RegistrarPeticionAPI(PeticionAPI peticion);
        List<PeticionAPI> ConsultarPeticiones(DateTime fechaDesde, DateTime fechaHasta);
    }
}
