using HealthTourist.Application.Contracts.Account;
using HealthTourist.Application.Contracts.Logging;
using HealthTourist.Domain.Account;
using HealthTourist.Persistence.DatabaseContexts;
using HealthTourist.Persistence.Repositories.Base;

namespace HealthTourist.Persistence.Repositories.Account;

public class PersonRepository(HealthTouristDbContext context, IAppLogger<Person> logger)
    : Repository<Person, long>(context, logger), IPersonRepository
{
}