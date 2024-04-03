using MediatR;

namespace HealthTourist.Application.Features.Main.TeamMember.Queries.GetTeamMembers;

public record GetTeamMembersQuery : IRequest<List<GetTeamMembersDto>>;
