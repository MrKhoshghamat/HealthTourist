using HealthTourist.Application.Contracts.Persistence.Base;
using HealthTourist.Domain;

namespace HealthTourist.Application.Contracts.Offices;

public interface IOfficeRepository : IRepository<Office, int>
{
    
}