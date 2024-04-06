using HealthTourist.Application.Contracts.Logging;
using HealthTourist.Application.Contracts.Main;
using HealthTourist.Domain.Main;
using HealthTourist.Persistence.DatabaseContexts;
using HealthTourist.Persistence.Repositories.Base;

namespace HealthTourist.Persistence.Repositories.Main;

public class SightseenRepository(HealthTouristDbContext context, IAppLogger<Sightseen> logger)
    : Repository<Sightseen, int>(context, logger), ISightseenRepository
{
}