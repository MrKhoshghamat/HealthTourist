using HealthTourist.Application.Contracts.AboutUsAttachments;
using HealthTourist.Application.Contracts.AboutUsPage;
using HealthTourist.Application.Contracts.Attachments;
using HealthTourist.Application.Contracts.Persistence.Base;
using HealthTourist.Persistence.DatabaseContexts;
using HealthTourist.Persistence.Repositories.AboutUsAttachments;
using HealthTourist.Persistence.Repositories.AboutUsPage;
using HealthTourist.Persistence.Repositories.Attachments;
using HealthTourist.Persistence.Repositories.Base;
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
            options.UseNpgsql(configuration.GetConnectionString("HealthTouristConnectionStringNpgsql"));
        });

        services.AddScoped(typeof(IRepository<,>), typeof(Repository<,>));
        services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        services.AddScoped<IAboutUsRepository, AboutUsRepository>();
        services.AddScoped<IAttachmentRepository, AttachmentRepository>();
        services.AddScoped<IAboutUsAttachmentRepository, AboutUsAttachmentRepository>();
        
        return services;
    }
}