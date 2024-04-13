using HealthTourist.Application.Contracts.Interface;
using HealthTourist.Application.Contracts.Logging;
using HealthTourist.Domain.Interface;
using HealthTourist.Persistence.DatabaseContexts;
using HealthTourist.Persistence.Repositories.Base;

namespace HealthTourist.Persistence.Repositories.Interface;

public class TriageAttachmentRepository(HealthTouristDbContext context, IAppLogger<TravelAttachment> logger)
    : Repository<TravelAttachment>(context, logger), ITriageAttachmentRepository
{
}