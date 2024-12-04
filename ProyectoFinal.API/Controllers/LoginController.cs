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
        private IBLUsuario _blUsuario;

        public LoginController(IConfiguration config, IBLUsuario bLUsuario)
        {
            _config = config;
            _blUsuario = bLUsuario;
        }

        [AllowAnonymous]
        [HttpPost("Login")]
        public IActionResult Login([FromBody] Usuario login)
        {
            IActionResult response = Unauthorized(new { Error = "Error de autenticación, usuario incorrecto." });
            var usuario = _blUsuario.AutenticarUsuario(login);

            if (usuario != null)
            {
                var nuevoToken = _blUsuario.GenerarTokenJWT(usuario);
                response = Ok(new { token = nuevoToken });
            }

            return response;
        }

        [AllowAnonymous]
        [HttpPost("CrearUsuario")]
        public IActionResult CrearUsuario([FromBody] Usuario login)
        {
            IActionResult response = Unauthorized();
            var usuario = _blUsuario.CrearUsuario(login);

            if (usuario)
            {
                response = Ok(new { Mensaje = "Usuario creado correctamente!" });
            }
            else
            {
                response = BadRequest();    
            }

            return response;
        }      
    }
}
