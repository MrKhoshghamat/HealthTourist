using AutoMapper;
using HealthTourist.Application.Contracts.Interface;
using HealthTourist.Common.Exceptions;
using HealthTourist.Domain.Interface;
using MediatR;

namespace HealthTourist.Application.Features.Main.TeamMember.Queries.GetTeamMemberAttachmentByTeamMemberId;

public class GetTeamMemberAttachmentByTeamMemberIdQueryHandler(ITeamMemberAttachmentRepository teamMemberAttachmentRepository, IMapper mapper)
: IRequestHandler<GetTeamMemberAttachmentByTeamMemberIdQuery, GetTeamMemberAttachmentByTeamMemberIdDto>
{
    public async Task<GetTeamMemberAttachmentByTeamMemberIdDto> Handle(GetTeamMemberAttachmentByTeamMemberIdQuery request, CancellationToken cancellationToken)
    {
        if (request == null) throw new BadRequestException("Incoming request is not valid");
        var teamMemberAttachment =
            await teamMemberAttachmentRepository.FindAsync(tma => tma.TeamMemberId == request.TeamMemberId);
        if (teamMemberAttachment == null)
            throw new NotFoundException(nameof(TeamMemberAttachment), request.TeamMemberId);

        var result = mapper.Map<GetTeamMemberAttachmentByTeamMemberIdDto>(teamMemberAttachment);
        return result;
    }
}