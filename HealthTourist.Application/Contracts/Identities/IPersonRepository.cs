using HealthTourist.Application.Contracts.Persistence.Base;
using HealthTourist.Domain.Account;

namespace HealthTourist.Application.Contracts.Identities;

public interface IPersonRepository : IRepository<Person, long>
{
    
}