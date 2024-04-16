using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using MediatR;

namespace HealthTourist.Application.Features.Main.Sightseen.Commands.CreateSightseen;

public class CreateSightseenCommandHandler(ISightseenRepository sightseenRepository, IMapper mapper)
    : IRequestHandler<CreateSightseenCommand, int>
{
    public async Task<int> Handle(CreateSightseenCommand request, CancellationToken cancellationToken)
    {
        var sightseen = mapper.Map<Domain.Main.Sightseen>(request);
        await sightseenRepository.CreateAsync(sightseen);
        return sightseen.Id;
    }
}