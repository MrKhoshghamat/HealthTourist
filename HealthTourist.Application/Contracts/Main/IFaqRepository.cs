using HealthTourist.Application.Contracts.Persistence.Base;
using HealthTourist.Domain.Main;

namespace HealthTourist.Application.Contracts.Main;

public interface IFaqRepository : IRepository<Faq, int>
{
    
}