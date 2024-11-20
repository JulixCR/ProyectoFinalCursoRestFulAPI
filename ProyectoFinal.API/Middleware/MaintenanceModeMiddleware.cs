using System.Net;

namespace PruebaMiddlewares
{
    public class MaintenanceModeMiddleware(RequestDelegate next, bool isInMaintenanceMode)
    {
        public async Task InvokeAsync(HttpContext context)
        {
            if (isInMaintenanceMode)
            {
                context.Response.StatusCode = (int)HttpStatusCode.ServiceUnavailable;
                await context.Response.WriteAsJsonAsync("Estamos en mantenimiento, intente m�s tarde.");
            }
            else
            {
                await next(context);
            }
        }
    }
}