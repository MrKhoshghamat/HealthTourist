using System.Data;
using HealthTourist.Application.Contracts.AboutUsPage;
using HealthTourist.Application.Contracts.Logging;
using HealthTourist.Domain;
using HealthTourist.Persistence.DatabaseContexts;
using HealthTourist.Persistence.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace HealthTourist.Persistence.Repositories.AboutUsPage;

public class AboutUsRepository(HealthTouristDbContext context, IAppLogger<AboutUs> logger)
    : Repository<AboutUs, int>(context, logger), IAboutUsRepository
{
    public async Task<AboutUs> GetCurrentAboutUs()
    {
        try
        {
            var currentAboutUs = await context.AboutUsDbset
                .Include(x => x.AboutUsAttachments)
                .Include(x => x.AboutUsTeamMembers)
                .Include(x => x.AboutUsOffices)
                .OrderByDescending(x => x.Id)
                .FirstOrDefaultAsync(x => !x.IsDeleted && !x.IsDisabled);

            return currentAboutUs!;
        }
        catch (Exception e)
        {
            logger.LogError(e.Message, e);
            throw new DataException(e.Message);
        }
    }

    public async Task<int> CreateAboutUsAndGetIdAsync(AboutUs aboutUs)
    {
        try
        {
            await CreateAsync(aboutUs);
            return aboutUs.Id;
        }
        catch (Exception e)
        {
            logger.LogError(e.Message, e);
            throw new DataException(e.Message);
        }
    }

    public async Task<bool> IsDeletedAsync(int id)
    {
        try
        {
            return await IsExistAsync(x => x.Id == id && !x.IsDeleted);
        }
        catch (Exception e)
        {
            logger.LogError(e.Message, e);
            throw new DataException(e.Message);
        }
    }
}