using HealthTourist.Application.Contracts.Persistence.Base;
using HealthTourist.Domain.Main;

namespace HealthTourist.Application.Contracts.Main;

public interface IGuestRepository : IRepository<Guest, long>
{
    
}