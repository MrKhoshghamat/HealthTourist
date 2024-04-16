using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using MediatR;

namespace HealthTourist.Application.Features.Main.TeamMember.Commands.DeleteTeamMember;

public class DeleteTeamMemberCommandHandler(ITeamMemberRepository teamMemberRepository, IMapper mapper)
    : IRequestHandler<DeleteTeamMemberCommand, Unit>
{
    public async Task<Unit> Handle(DeleteTeamMemberCommand request, CancellationToken cancellationToken)
    {
        var teamMember = mapper.Map<Domain.Main.TeamMember>(request);
        await teamMemberRepository.DeleteAsync(teamMember);
        return Unit.Value;
    }
}