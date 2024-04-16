using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using MediatR;

namespace HealthTourist.Application.Features.Main.Sightseen.Commands.UpdateSightseen;

public class UpdateSightseenCommandHandler(ISightseenRepository sightseenRepository, IMapper mapper)
    : IRequestHandler<UpdateSightseenCommand, Unit>
{
    public async Task<Unit> Handle(UpdateSightseenCommand request, CancellationToken cancellationToken)
    {
        var sightseen = mapper.Map<Domain.Main.Sightseen>(request);
        await sightseenRepository.UpdateAsync(sightseen);
        return Unit.Value;
    }
}