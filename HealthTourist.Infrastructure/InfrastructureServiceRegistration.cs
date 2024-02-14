using HealthTourist.Application.Contracts.Logging;
using HealthTourist.Infrastructure.Logging;
using Microsoft.Extensions.DependencyInjection;

namespace HealthTourist.Infrastructure;

public static class InfrastructureServiceRegistration
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
    {
        services.AddScoped(typeof(IAppLogger<>), typeof(LoggerAdapter<>));

        return services;
    }
}