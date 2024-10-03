namespace VSATemplate.Extensions;

public static class DatabaseExtensions
{
    public static void AddSQLDatabaseConfiguration(this IServiceCollection services, 
        IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(context =>
                    context.UseSqlServer(configuration.GetConnectionString("SQLConnection")));
    }
}