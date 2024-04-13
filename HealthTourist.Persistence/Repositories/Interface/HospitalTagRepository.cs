using HealthTourist.Application.Contracts.Interface;
using HealthTourist.Application.Contracts.Logging;
using HealthTourist.Domain.Interface;
using HealthTourist.Persistence.DatabaseContexts;
using HealthTourist.Persistence.Repositories.Base;

namespace HealthTourist.Persistence.Repositories.Interface;

public class HospitalTagRepository(HealthTouristDbContext context, IAppLogger<HospitalTag> logger)
    : Repository<HospitalTag>(context, logger), IHospitalTagRepository
{
}