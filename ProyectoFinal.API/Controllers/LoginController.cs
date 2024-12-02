using ProyectoFinal.ET;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using ProyectoFinal.BL;


namespace ProyectoFinal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private IConfiguration _config;
        private BLUsuario _blUsuario;

        public LoginController(IConfiguration config, BLUsuario bLUsuario)
        {
            _config = config;
            _blUsuario = bLUsuario;
        }

        [AllowAnonymous]
        [HttpPost("Login")]
        public IActionResult Login([FromBody] Usuario login)
        {
            IActionResult response = Unauthorized();
            var usuario = _blUsuario.AutenticarUsuario(login);

            if (usuario != null)
            {
                var nuevoToken = _blUsuario.GenerarTokenJWT(usuario);
                response = Ok(new { token = nuevoToken });
            }

            return response;
        }

        //private Usuario AutenticarUsuario(Usuario login)
        //{
        //    Usuario usuario = null;

        //    if (login.Id == "0087")
        //    {
        //        usuario = new Usuario
        //        {
        //            Id = login.Id,
        //            Nombre = login.Nombre
        //        };
        //    }
        //    return usuario;
        //}

        //private string GenerarTokenJWT(Usuario usuario) 
        //{
        //    var llaveSeguridad = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
        //    var credenciales = new SigningCredentials(llaveSeguridad, SecurityAlgorithms.HmacSha256);

        //    var claims = new[] {
        //        new Claim(JwtRegisteredClaimNames.Sub, usuario.Id),
        //        new Claim(JwtRegisteredClaimNames.Name, usuario.Nombre),
        //        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
        //    };

        //    var token = new JwtSecurityToken(_config["Jwt:Issuer"],
        //        _config["Jwt:Issuer"],
        //        claims,
        //        expires: DateTime.Now.AddMinutes(20),
        //        signingCredentials: credenciales);

        //    return new JwtSecurityTokenHandler().WriteToken(token);
        //}
    }
}
