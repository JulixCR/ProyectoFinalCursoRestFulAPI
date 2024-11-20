using System.Net;

namespace PruebaMiddlewares
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