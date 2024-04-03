using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using HealthTourist.Common.Exceptions;
using MediatR;

namespace HealthTourist.Application.Features.Main.TeamMember.Queries.GetTeamMembers;

public class GetTeamMembersQueryHandler(ITeamMemberRepository teamMemberRepository, IMapper mapper)
    : IRequestHandler<GetTeamMembersQuery, List<GetTeamMembersDto>>
{
    public async Task<List<GetTeamMembersDto>> Handle(GetTeamMembersQuery request, CancellationToken cancellationToken)
    {
        if (request == null) throw new BadRequestException("Incoming request is not valid");
        var teamMembers = await teamMemberRepository.GetAllAsync();
        if (teamMembers == null) throw new NotFoundException(nameof(List<Domain.Main.TeamMember>), request);

        var result = mapper.Map<List<GetTeamMembersDto>>(teamMembers);
        return result;
    }
}