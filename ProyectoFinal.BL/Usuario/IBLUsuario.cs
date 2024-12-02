using ProyectoFinal.ET;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using ProyectoFinal.DS;

namespace ProyectoFinal.BL
{
    public interface IBLUsuario
    {
        Usuario AutenticarUsuario(Usuario login);

        string GenerarTokenJWT(Usuario usuario);

        bool CrearUsuario(Usuario login);
    }
}
