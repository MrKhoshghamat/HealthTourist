using System.Data;
using HealthTourist.Application.Contracts.Attachments;
using HealthTourist.Application.Contracts.Logging;
using HealthTourist.Domain.Common;
using HealthTourist.Persistence.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace HealthTourist.Persistence.Repositories.Attachments;

public class AttachmentRepository(DbContext context, IAppLogger<Attachment> logger) 
    : Repository<Attachment, Guid>(context, logger), IAttachmentRepository
{
    public async Task<Guid> CreateAttachmentAndGetIdAsync(Attachment attachment)
    {
        try
        {
            await CreateAsync(attachment);
            return attachment.Id;
        }
        catch (Exception e)
        {
            logger.LogError(e.Message, e);
            throw new DataException(e.Message);
        }
    }

    public async Task<bool> IsDeletedAsync(Guid id)
    {
        try
        {
            return await IsExistAsync(x => x.Id == id && x.IsDeleted);
        }
        catch (Exception e)
        {
            logger.LogError(e.Message, e);
            throw new DataException(e.Message);
        }
    }
}