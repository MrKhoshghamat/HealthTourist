using HealthTourist.Application.Contracts.Account;
using HealthTourist.Application.Contracts.Common;
using HealthTourist.Application.Contracts.Main;
using HealthTourist.Application.Contracts.Persistence.Base;
using HealthTourist.Persistence.DatabaseContexts;
using HealthTourist.Persistence.Repositories.Account;
using HealthTourist.Persistence.Repositories.Base;
using HealthTourist.Persistence.Repositories.Common;
using HealthTourist.Persistence.Repositories.Main;
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

        services.AddScoped<IPersonRepository, PersonRepository>();

        services.AddScoped<IAttachmentRepository, AttachmentRepository>();
        services.AddScoped<ICityRepository, CityRepository>();
        services.AddScoped<ICountryRepository, CountryRepository>();
        services.AddScoped<IStateRepository, StateRepository>();

        services.AddScoped<IAirLineRepository, AirLineRepository>();
        services.AddScoped<ICategoryRepository, CategoryRepository>();
        services.AddScoped<ICostDetailsRepository, CostDetailsRepository>();
        services.AddScoped<IDoctorRepository, DoctorRepository>();
        services.AddScoped<IFaqRepository, FaqRepository>();
        services.AddScoped<IFaqTypeRepository, FaqTypeRepository>();
        services.AddScoped<IGuestRepository, GuestRepository>();
        services.AddScoped<IHealthCostRepository, HealthCostRepository>();
        services.AddScoped<IHealthRepository, HealthRepository>();
        services.AddScoped<IHospitalRepository, HospitalRepository>();
        services.AddScoped<IHospitalTypeRepository, HospitalTypeRepository>();
        services.AddScoped<IHotelRankRepository, HotelRankRepository>();
        services.AddScoped<IHotelRepository, HotelRepository>();
        services.AddScoped<IHotelTypeRepository, HotelTypeRepository>();
        services.AddScoped<IInvoiceCostRepository, InvoiceCostRepository>();
        services.AddScoped<IInvoiceRepository, InvoiceRepository>();
        services.AddScoped<IOfficeManagerRepository, OfficeManagerRepository>();
        services.AddScoped<IOfficeRepository, OfficeRepository>();
        services.AddScoped<IPatientRepository, PatientRepository>();
        services.AddScoped<ISightseenRepository, SightseenRepository>();
        services.AddScoped<ITagRepository, TagRepository>();
        services.AddScoped<ITeamMemberRepository, TeamMemberRepository>();
        services.AddScoped<ITravelCostRepository, TravelCostRepository>();
        services.AddScoped<ITravelRepository, TravelRepository>();
        services.AddScoped<ITreatmentRepository, TreatmentRepository>();
        services.AddScoped<ITreatmentTypeRepository, TreatmentTypeRepository>();
        services.AddScoped<ITriageRepository, TriageRepository>();

        return services;
    }
}