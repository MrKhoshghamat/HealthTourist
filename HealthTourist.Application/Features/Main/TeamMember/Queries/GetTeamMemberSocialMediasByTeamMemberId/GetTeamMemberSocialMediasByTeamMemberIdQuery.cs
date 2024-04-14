using MediatR;

namespace HealthTourist.Application.Features.Main.TeamMember.Queries.GetTeamMemberSocialMediasByTeamMemberId;

public record GetTeamMemberSocialMediasByTeamMemberIdQuery(long TeamMemberId)
    : IRequest<GetTeamMemberSocialMediasByTeamMemberIdDto>;
