using HealthTourist.Application.Contracts.Interface;
using HealthTourist.Application.Contracts.Logging;
using HealthTourist.Domain.Interface;
using HealthTourist.Persistence.DatabaseContexts;
using HealthTourist.Persistence.Repositories.Base;

namespace HealthTourist.Persistence.Repositories.Interface;

public class FaqTypeAttachmentRepository(HealthTouristDbContext context, IAppLogger<FaqTypeAttachment> logger)
    : Repository<FaqTypeAttachment>(context, logger), IFaqTypeAttachmentRepository
{
}