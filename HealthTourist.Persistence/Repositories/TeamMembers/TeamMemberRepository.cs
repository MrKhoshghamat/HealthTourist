using HealthTourist.Application.Contracts.Logging;
using HealthTourist.Application.Contracts.TeamMembers;
using HealthTourist.Domain;
using HealthTourist.Persistence.DatabaseContexts;
using HealthTourist.Persistence.Repositories.Base;

namespace HealthTourist.Persistence.Repositories.TeamMembers;

public class TeamMemberRepository(HealthTouristDbContext context, IAppLogger<TeamMember> logger)
    : Repository<TeamMember, int>(context, logger), ITeamMemberRepository
{
}