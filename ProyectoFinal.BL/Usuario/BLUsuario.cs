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
    public class BLUsuario : IBLUsuario
    {
        private IConfiguration _config;
        private IUsuarioRepository _usuario;

        public BLUsuario(IUsuarioRepository usuario, IConfiguration config) 
        {
            _config = config;
            _usuario = usuario; 
        }

        public Usuario AutenticarUsuario(Usuario login)
        {
            Usuario usuario = null;          

            usuario = _usuario.ConsultarCredenciales(login);

            return usuario;
        }

        public string GenerarTokenJWT(Usuario usuario)
        {
            var llaveSeguridad = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credenciales = new SigningCredentials(llaveSeguridad, SecurityAlgorithms.HmacSha256);

            var claims = new[] {
                new Claim(JwtRegisteredClaimNames.Sub, usuario.IdUsuario),
                new Claim(JwtRegisteredClaimNames.Name, usuario.Nombre),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var token = new JwtSecurityToken(_config["Jwt:Issuer"],
                _config["Jwt:Issuer"],
                claims,
                expires: DateTime.Now.AddMinutes(20),
                signingCredentials: credenciales);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public bool CrearUsuario(Usuario login)
        {
            return _usuario.InsertarCredenciales(login);
        }
    }
}
