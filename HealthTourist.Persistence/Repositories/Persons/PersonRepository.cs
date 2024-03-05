using HealthTourist.Application.Contracts.Identities;
using HealthTourist.Application.Contracts.Logging;
using HealthTourist.Domain.Account;
using HealthTourist.Persistence.DatabaseContexts;
using HealthTourist.Persistence.Repositories.Base;

namespace HealthTourist.Persistence.Repositories.Persons;

public class PersonRepository(HealthTouristDbContext context, IAppLogger<Person> logger)
    : Repository<Person, long>(context, logger), IPersonRepository
{
}