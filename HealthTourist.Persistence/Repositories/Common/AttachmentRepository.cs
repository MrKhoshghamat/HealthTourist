using HealthTourist.Application.Contracts.Common;
using HealthTourist.Application.Contracts.Logging;
using HealthTourist.Domain.Common;
using HealthTourist.Persistence.DatabaseContexts;
using HealthTourist.Persistence.Repositories.Base;

namespace HealthTourist.Persistence.Repositories.Common;

public class AttachmentRepository(HealthTouristDbContext context, IAppLogger<Attachment> logger)
    : Repository<Attachment, Guid>(context, logger), IAttachmentRepository
{
}