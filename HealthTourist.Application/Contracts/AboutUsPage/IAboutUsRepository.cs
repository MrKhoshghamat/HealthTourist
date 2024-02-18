using HealthTourist.Application.Contracts.Persistence.Base;
using HealthTourist.Domain.AboutUsPage;

namespace HealthTourist.Application.Contracts.AboutUsPage;

public interface IAboutUsRepository : IRepository<AboutUs, int>
{
    Task<int> CreateAboutUsAndGetIdAsync(AboutUs aboutUs);
    Task<bool> IsDeletedAsync(int id);
}