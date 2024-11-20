using System.Net;

namespace PruebaMiddlewares
{
    public static class CustomLoggingMiddlewareExtension
    {
        public static IApplicationBuilder UseCustomLoggingMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CustomLoggingMiddleware>();

        }
    }
}
