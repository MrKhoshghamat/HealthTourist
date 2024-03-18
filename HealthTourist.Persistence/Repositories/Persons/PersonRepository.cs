using System.Data;
using HealthTourist.Application.Contracts.Identities;
using HealthTourist.Application.Contracts.Logging;
using HealthTourist.Domain.Account;
using HealthTourist.Persistence.DatabaseContexts;
using HealthTourist.Persistence.Repositories.Base;

namespace HealthTourist.Persistence.Repositories.Persons;

public class PersonRepository(HealthTouristDbContext context, IAppLogger<Person> logger)
    : Repository<Person, long>(context, logger), IPersonRepository
{
    public async Task<long> CreatePersonAndGetId(Person person)
    {
        try
        {
            await context.Persons.AddAsync(person);
            return person.Id;
        }
        catch (Exception e)
        {
            logger.LogError(e.Message, e);
            throw new DataException(e.Message);
        }
    }
}