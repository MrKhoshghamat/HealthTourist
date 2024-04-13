using HealthTourist.Application.Contracts.Interface;
using HealthTourist.Application.Contracts.Logging;
using HealthTourist.Domain.Interface;
using HealthTourist.Persistence.DatabaseContexts;
using HealthTourist.Persistence.Repositories.Base;

namespace HealthTourist.Persistence.Repositories.Interface;

public class SightseenAttachmentRepository(HealthTouristDbContext context, IAppLogger<SightseenAttachment> logger)
    : Repository<SightseenAttachment>(context, logger), ISightseenAttachmentRepository
{
}