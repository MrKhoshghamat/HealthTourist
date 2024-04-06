using AutoMapper;
using HealthTourist.Application.Features.Main.TeamMember.Queries.GetTeamMemberDetails;
using HealthTourist.Application.Features.Main.TeamMember.Queries.GetTeamMembers;
using HealthTourist.Domain.Main;

namespace HealthTourist.Application.MappingProfiles.Main;

public class TeamMemberProfile : Profile
{
    public TeamMemberProfile()
    {
        CreateMap<TeamMember, GetTeamMembersDto>().ReverseMap();
        CreateMap<TeamMember, GetTeamMemberDetailsDto>().ReverseMap();
    }
}