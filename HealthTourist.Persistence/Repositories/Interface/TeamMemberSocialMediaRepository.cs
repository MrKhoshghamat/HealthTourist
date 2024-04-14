using HealthTourist.Application.Contracts.Interface;
using HealthTourist.Application.Contracts.Logging;
using HealthTourist.Domain.Interface;
using HealthTourist.Persistence.DatabaseContexts;
using HealthTourist.Persistence.Repositories.Base;

namespace HealthTourist.Persistence.Repositories.Interface;

public class TeamMemberSocialMediaRepository(HealthTouristDbContext context, IAppLogger<TeamMemberSocialMedia> logger)
    : Repository<TeamMemberSocialMedia>(context, logger), ITeamMemberSocialMediaRepository
{
}