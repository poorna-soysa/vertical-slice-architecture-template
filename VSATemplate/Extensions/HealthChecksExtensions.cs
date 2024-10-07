namespace VSATemplate.Extensions;

public static class HealthChecksExtensions
{
    public static IServiceCollection AddHealthChecksConfiguration(this IServiceCollection services)
    {
        services.AddHealthChecks()
            .AddDbContextCheck<ApplicationDbContext>();
        return services;
    }
    public static IApplicationBuilder MapHealthChecksConfiguration(this WebApplication app)
    {
        app.MapHealthChecks("health", new HealthCheckOptions
        {
            ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
        });
        return app;
    }
}