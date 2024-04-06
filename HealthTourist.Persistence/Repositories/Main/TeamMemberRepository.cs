using HealthTourist.Application.Contracts.Logging;
using HealthTourist.Application.Contracts.Main;
using HealthTourist.Domain.Main;
using HealthTourist.Persistence.DatabaseContexts;
using HealthTourist.Persistence.Repositories.Base;

namespace HealthTourist.Persistence.Repositories.Main;

public class TeamMemberRepository(HealthTouristDbContext context, IAppLogger<TeamMember> logger)
    : Repository<TeamMember, long>(context, logger), ITeamMemberRepository
{
}