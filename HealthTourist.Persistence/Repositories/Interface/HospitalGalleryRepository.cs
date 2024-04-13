using HealthTourist.Application.Contracts.Interface;
using HealthTourist.Application.Contracts.Logging;
using HealthTourist.Domain.Interface;
using HealthTourist.Persistence.DatabaseContexts;
using HealthTourist.Persistence.Repositories.Base;

namespace HealthTourist.Persistence.Repositories.Interface;

public class HospitalGalleryRepository(HealthTouristDbContext context, IAppLogger<HospitalGallery> logger)
    : Repository<HospitalGallery>(context, logger), IHospitalGalleryRepository
{
}