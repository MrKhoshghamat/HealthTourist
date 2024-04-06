using HealthTourist.Application.Contracts.Common;
using HealthTourist.Application.Contracts.Logging;
using HealthTourist.Domain.Common;
using HealthTourist.Persistence.DatabaseContexts;
using HealthTourist.Persistence.Repositories.Base;

namespace HealthTourist.Persistence.Repositories.Common;

public class CountryRepository(HealthTouristDbContext context, IAppLogger<Country> logger)
    : Repository<Country, int>(context, logger), ICountryRepository
{
}