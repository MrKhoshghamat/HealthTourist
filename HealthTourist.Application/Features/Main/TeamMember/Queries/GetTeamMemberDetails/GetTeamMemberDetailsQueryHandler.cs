using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using HealthTourist.Common.Exceptions;
using MediatR;

namespace HealthTourist.Application.Features.Main.TeamMember.Queries.GetTeamMemberDetails;

public class GetTeamMemberDetailsQueryHandler(ITeamMemberRepository teamMemberRepository, IMapper mapper)
    : IRequestHandler<GetTeamMemberDetailsQuery, GetTeamMemberDetailsDto>
{
    public async Task<GetTeamMemberDetailsDto> Handle(GetTeamMemberDetailsQuery request,
        CancellationToken cancellationToken)
    {
        if (request == null) throw new BadRequestException("Incoming request is not valid");
        var teamMemberDetails = await teamMemberRepository.FindAsync(request.Id);
        if (teamMemberDetails == null) throw new NotFoundException(nameof(Domain.Main.TeamMember), request.Id);

        var result = mapper.Map<GetTeamMemberDetailsDto>(teamMemberDetails);
        return result;
    }
}