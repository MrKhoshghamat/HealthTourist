using HealthTourist.Application.Contracts.Persistence.Base;
using HealthTourist.Domain.Common;

namespace HealthTourist.Application.Contracts.Common;

public interface ICityRepository : IRepository<City, int>
{
    
}