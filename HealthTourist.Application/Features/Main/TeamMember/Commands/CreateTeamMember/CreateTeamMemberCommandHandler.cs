using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using MediatR;

namespace HealthTourist.Application.Features.Main.TeamMember.Commands.CreateTeamMember;

public class CreateTeamMemberCommandHandler(ITeamMemberRepository teamMemberRepository, IMapper mapper)
    : IRequestHandler<CreateTeamMemberCommand, long>
{
    public async Task<long> Handle(CreateTeamMemberCommand request, CancellationToken cancellationToken)
    {
        var teamMember = mapper.Map<Domain.Main.TeamMember>(request);
        await teamMemberRepository.CreateAsync(teamMember);
        return teamMember.Id;
    }
}