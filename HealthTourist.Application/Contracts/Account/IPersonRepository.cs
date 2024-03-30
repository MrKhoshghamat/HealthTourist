using HealthTourist.Application.Contracts.Persistence.Base;
using HealthTourist.Domain.Account;

namespace HealthTourist.Application.Contracts.Account;

public interface IPersonRepository : IRepository<Person, long>
{
    
}