using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using HealthTourist.Common.Exceptions;
using MediatR;

namespace HealthTourist.Application.Features.Main.TeamMember.Queries.GetTeamMembersByDoctorId;

public class GetTeamMembersByDoctorIdQueryHandler(ITeamMemberRepository teamMemberRepository, IMapper mapper)
: IRequestHandler<GetTeamMembersByDoctorIdQuery, List<GetTeamMembersByDoctorIdDto>>
{
    public async Task<List<GetTeamMembersByDoctorIdDto>> Handle(GetTeamMembersByDoctorIdQuery request, CancellationToken cancellationToken)
    {
        if (request == null) throw new BadRequestException("Incoming request is not valid");
        var teamMembers = await teamMemberRepository.GetAllAsync(tm => tm.DoctorId == request.DoctorId);
        if (teamMembers == null) throw new NotFoundException(nameof(List<Domain.Main.TeamMember>), request.DoctorId);

        var result = mapper.Map<List<GetTeamMembersByDoctorIdDto>>(teamMembers);
        return result;
    }
}