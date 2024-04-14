using AutoMapper;
using HealthTourist.Application.Contracts.Interface;
using HealthTourist.Common.Exceptions;
using HealthTourist.Domain.Interface;
using MediatR;

namespace HealthTourist.Application.Features.Main.TeamMember.Queries.GetTeamMemberSocialMediasByTeamMemberId;

public class GetTeamMemberSocialMediasByTeamMemberIdQueryHandler(
    ITeamMemberSocialMediaRepository teamMemberSocialMediaRepository,
    IMapper mapper)
    : IRequestHandler<GetTeamMemberSocialMediasByTeamMemberIdQuery, GetTeamMemberSocialMediasByTeamMemberIdDto>
{
    public async Task<GetTeamMemberSocialMediasByTeamMemberIdDto> Handle(
        GetTeamMemberSocialMediasByTeamMemberIdQuery request, CancellationToken cancellationToken)
    {
        if (request == null) throw new BadRequestException("Incoming request is not valid");
        var teamMemberSocialMediae =
            await teamMemberSocialMediaRepository.GetAllAsync(tmsm => tmsm.TeamMemberId == request.TeamMemberId);
        if (teamMemberSocialMediae == null)
            throw new NotFoundException(nameof(TeamMemberSocialMedia), request.TeamMemberId);

        var result = mapper.Map<GetTeamMemberSocialMediasByTeamMemberIdDto>(teamMemberSocialMediae);
        return result;
    }
}