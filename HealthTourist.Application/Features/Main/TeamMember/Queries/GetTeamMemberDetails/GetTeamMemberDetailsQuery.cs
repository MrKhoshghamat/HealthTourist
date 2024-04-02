using MediatR;

namespace HealthTourist.Application.Features.Main.TeamMember.Queries.GetTeamMemberDetails;

public record GetTeamMemberDetailsQuery(long Id) : IRequest<GetTeamMemberDetailsDto>;
