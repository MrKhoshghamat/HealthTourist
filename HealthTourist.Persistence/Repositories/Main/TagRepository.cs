using HealthTourist.Application.Contracts.Logging;
using HealthTourist.Application.Contracts.Main;
using HealthTourist.Domain.Main;
using HealthTourist.Persistence.DatabaseContexts;
using HealthTourist.Persistence.Repositories.Base;

namespace HealthTourist.Persistence.Repositories.Main;

public class TagRepository(HealthTouristDbContext context, IAppLogger<Tag> logger)
    : Repository<Tag, int>(context, logger), ITagRepository
{
}