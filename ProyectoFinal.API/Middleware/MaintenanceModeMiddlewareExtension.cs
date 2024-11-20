namespace PruebaMiddlewares
{

    public static class MaintenanceModeMiddlewareExtension
    {
        public static IApplicationBuilder UseMaintenanceModeMiddleware(this IApplicationBuilder builder, bool isInMaintenanceMode)
        {
            return builder.UseMiddleware<MaintenanceModeMiddleware>(isInMaintenanceMode);

        }
    }
}