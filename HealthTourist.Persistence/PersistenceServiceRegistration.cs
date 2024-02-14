using HealthTourist.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HealthTourist.Persistence;

public static class PersistenceServiceRegistration
{
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContext<HealthTouristDbContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("HealthTouristDatabaseConnectionString"));
        });
        return services;
    }
}