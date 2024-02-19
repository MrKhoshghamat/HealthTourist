using System.Data;
using HealthTourist.Application.Contracts.AboutUsAttachments;
using HealthTourist.Application.Contracts.Logging;
using HealthTourist.Domain.AboutUsPage;
using HealthTourist.Persistence.DatabaseContexts;
using HealthTourist.Persistence.Repositories.Base;

namespace HealthTourist.Persistence.Repositories.AboutUsAttachments;

public class AboutUsAttachmentRepository(HealthTouristDbContext context, IAppLogger<AboutUsAttachment> logger)
    : Repository<AboutUsAttachment>(context, logger), IAboutUsAttachmentRepository
{
    public async Task<bool> IsDeletedAsync(int aboutUsId, Guid attachmentId)
    {
        try
        {
            return await IsExistAsync(x =>
                x.AboutUsId == aboutUsId
                && x.AttachmentId == attachmentId);
        }
        catch (Exception e)
        {
            logger.LogError(e.Message, e);
            throw new DataException(e.Message);
        }
    }

    public async Task<AboutUsAttachment> GetAboutUsAttachmentAsync(int aboutUsId, Guid attachmentId)
    {
        try
        {
            return await FindAsync(x => x.AboutUsId == aboutUsId && x.AttachmentId == attachmentId);
        }
        catch (Exception e)
        {
            logger.LogError(e.Message, e);
            throw new DataException(e.Message);
        }
    }
}