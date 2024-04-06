using HealthTourist.Application.Contracts.Logging;
using HealthTourist.Application.Contracts.Main;
using HealthTourist.Domain.Main;
using HealthTourist.Persistence.DatabaseContexts;
using HealthTourist.Persistence.Repositories.Base;

namespace HealthTourist.Persistence.Repositories.Main;

public class FaqTypeRepository(HealthTouristDbContext context, IAppLogger<FaqType> logger)
    : Repository<FaqType, int>(context, logger), IFaqTypeRepository
{
}