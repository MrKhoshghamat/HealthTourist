using MediatR;

namespace HealthTourist.Application.Features.Main.TeamMember.Queries.GetTeamMemberAttachmentByTeamMemberId;

public record GetTeamMemberAttachmentByTeamMemberIdQuery(long TeamMemberId)
    : IRequest<GetTeamMemberAttachmentByTeamMemberIdDto>;
