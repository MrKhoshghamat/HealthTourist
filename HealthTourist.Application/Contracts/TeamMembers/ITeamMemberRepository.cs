using HealthTourist.Application.Contracts.Persistence.Base;
using HealthTourist.Domain;

namespace HealthTourist.Application.Contracts.TeamMembers;

public interface ITeamMemberRepository : IRepository<TeamMember, int>
{
    
}