using HealthTourist.Application.Contracts.Logging;
using HealthTourist.Application.Contracts.Offices;
using HealthTourist.Domain.AboutUsPage;
using HealthTourist.Persistence.DatabaseContexts;
using HealthTourist.Persistence.Repositories.Base;

namespace HealthTourist.Persistence.Repositories.Offices;

public class OfficeRepository(HealthTouristDbContext context, IAppLogger<Office> logger)
    : Repository<Office, int>(context, logger), IOfficeRepository
{
}