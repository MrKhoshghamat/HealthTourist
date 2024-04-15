using HealthTourist.Application.Contracts.Account;
using HealthTourist.Application.Contracts.Common;
using HealthTourist.Application.Contracts.Interface;
using HealthTourist.Application.Contracts.Main;
using HealthTourist.Application.Contracts.Persistence.Base;
using HealthTourist.Persistence.DatabaseContexts;
using HealthTourist.Persistence.Repositories.Account;
using HealthTourist.Persistence.Repositories.Base;
using HealthTourist.Persistence.Repositories.Common;
using HealthTourist.Persistence.Repositories.Interface;
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

        services.AddScoped<ICityAttachmentRepository, CityAttachmentRepository>();
        services.AddScoped<IDoctorAttachmentRepository, DoctorAttachmentRepository>();
        services.AddScoped<IDoctorSocialMediaRepository, DoctorSocialMediaRepository>();
        services.AddScoped<IFaqTypeAttachmentRepository, FaqTypeAttachmentRepository>();
        services.AddScoped<IHealthAttachmentRepository, HealthAttachmentRepository>();
        services.AddScoped<IHospitalAttachmentRepository, HospitalAttachmentRepository>();
        services.AddScoped<IHospitalGalleryRepository, HospitalGalleryRepository>();
        services.AddScoped<IHospitalTagRepository, HospitalTagRepository>();
        services.AddScoped<IHotelAttachmentRepository, HotelAttachmentRepository>();
        services.AddScoped<IHotelGalleryRepository, HotelGalleryRepository>();
        services.AddScoped<IHotelTagRepository, HotelTagRepository>();
        services.AddScoped<IOfficeAttachmentRepository, OfficeAttachmentRepository>();
        services.AddScoped<ISightseenAttachmentRepository, SightseenAttachmentRepository>();
        services.AddScoped<ISightseenCategoryRepository, SightseenCategoryRepository>();
        services.AddScoped<ITeamMemberAttachmentRepository, TeamMemberAttachmentRepository>();
        services.AddScoped<ITeamMemberSocialMediaRepository, TeamMemberSocialMediaRepository>();
        services.AddScoped<ITravelAttachmentRepository, TravelAttachmentRepository>();
        services.AddScoped<ITravelGuestRepository, TravelGuestRepository>();
        services.AddScoped<ITreatmentTypeAttachmentRepository, TreatmentTypeAttachmentRepository>();
        services.AddScoped<ITriageAttachmentRepository, TriageAttachmentRepository>();

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