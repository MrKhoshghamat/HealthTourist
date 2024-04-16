using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using MediatR;

namespace HealthTourist.Application.Features.Main.Sightseen.Commands.DeleteSightseen;

public class DeleteSightseenCommandHandler(ISightseenRepository sightseenRepository, IMapper mapper)
    : IRequestHandler<DeleteSightseenCommand, Unit>
{
    public async Task<Unit> Handle(DeleteSightseenCommand request, CancellationToken cancellationToken)
    {
        var sightseen = mapper.Map<Domain.Main.Sightseen>(request);
        await sightseenRepository.DeleteAsync(sightseen);
        return Unit.Value;
    }
}