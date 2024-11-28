using System.Net;

namespace ProyectoFinal.API
{
    public class CustomExceptionHandlerMiddleware(RequestDelegate next)
    {
        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await next(context);
            }
            catch (Exception)
            {
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

                await context.Response.WriteAsJsonAsync("Ocurrio un error, contacte al administrador.");
            }
        }

    }
}