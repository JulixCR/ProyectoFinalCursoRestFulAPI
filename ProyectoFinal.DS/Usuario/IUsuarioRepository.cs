using ProyectoFinal.ET;
using System.Threading.Tasks;

namespace ProyectoFinal.DS
{
    public interface IUsuarioRepository
    {
        Usuario ConsultarCredenciales(Usuario login);
        bool InsertarCredenciales(Usuario login);
    }
}
