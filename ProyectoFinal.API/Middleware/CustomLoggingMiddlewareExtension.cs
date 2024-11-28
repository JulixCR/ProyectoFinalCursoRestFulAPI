using System.Net;

namespace ProyectoFinal.API
{
    public static class CustomLoggingMiddlewareExtension
    {
        public static IApplicationBuilder UseCustomLoggingMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CustomLoggingMiddleware>();

        }
    }
}
