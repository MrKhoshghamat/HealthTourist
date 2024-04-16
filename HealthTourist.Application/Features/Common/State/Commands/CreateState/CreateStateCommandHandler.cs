using AutoMapper;
using HealthTourist.Application.Contracts.Common;
using MediatR;

namespace HealthTourist.Application.Features.Common.State.Commands.CreateState;

public class CreateStateCommandHandler(IStateRepository stateRepository, IMapper mapper)
    : IRequestHandler<CreateStateCommand, int>
{
    public async Task<int> Handle(CreateStateCommand request, CancellationToken cancellationToken)
    {
        var state = mapper.Map<Domain.Common.State>(request);
        await stateRepository.CreateAsync(state);
        return state.Id;
    }
}