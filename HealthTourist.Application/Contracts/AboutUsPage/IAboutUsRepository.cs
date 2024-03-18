using HealthTourist.Application.Contracts.Persistence.Base;
using HealthTourist.Domain;

namespace HealthTourist.Application.Contracts.AboutUsPage;

public interface IAboutUsRepository : IRepository<AboutUs, int>
{
    Task<AboutUs> GetCurrentAboutUs();
    Task<int> CreateAboutUsAndGetIdAsync(AboutUs aboutUs);
    Task<bool> IsDeletedAsync(int id);
}