using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using MediatR;

namespace HealthTourist.Application.Features.Main.TeamMember.Commands.UpdateTeamMember;

public class UpdateTeamMemberCommandHandler(ITeamMemberRepository teamMemberRepository, IMapper mapper)
    : IRequestHandler<UpdateTeamMemberCommand, Unit>
{
    public async Task<Unit> Handle(UpdateTeamMemberCommand request, CancellationToken cancellationToken)
    {
        var teamMember = mapper.Map<Domain.Main.TeamMember>(request);
        await teamMemberRepository.UpdateAsync(teamMember);
        return Unit.Value;
    }
}