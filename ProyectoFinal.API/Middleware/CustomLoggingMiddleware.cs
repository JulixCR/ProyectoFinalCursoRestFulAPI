using System.Net;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using ProyectoFinal.BL;
using ProyectoFinal.ET;

namespace ProyectoFinal.API
{
    public class CustomLoggingMiddleware(RequestDelegate next, ILogger<CustomLoggingMiddleware> logger, IBLBitacora bitacora)
    {
        private IBLBitacora _bitacora;
        public async Task InvokeAsync(HttpContext context)
        {
            _bitacora = bitacora;

            await next(context);

            if (!context.Request.Path.ToString().Contains("swagger"))
            {
                PeticionAPI peticion = new PeticionAPI
                {
                    Endpoint = context.Request.Path,
                    IdUsuario = context.User.Identity.IsAuthenticated ? context.User.Claims.Where(x => x.Type == "name").FirstOrDefault().Value : "Anonymous",
                };

                _bitacora.RegistrarEvento(peticion);
            }
            
        }
    }
}
