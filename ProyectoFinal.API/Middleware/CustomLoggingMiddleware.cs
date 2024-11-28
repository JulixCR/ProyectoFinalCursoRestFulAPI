using System.Net;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace ProyectoFinal.API
{
    public class CustomLoggingMiddleware(RequestDelegate next, ILogger<CustomLoggingMiddleware> logger)
    {
        public async Task InvokeAsync(HttpContext context)
        {
            logger.LogInformation("Log antes de la solicitud.");

            await next(context);

            logger.LogInformation("Log despues de la solicitud.");
        }
    }
}
