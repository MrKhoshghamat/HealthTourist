using AutoMapper;
using HealthTourist.Application.Contracts.Common;
using MediatR;

namespace HealthTourist.Application.Features.Common.State.Commands.UpdateState;

public class UpdateStateCommandHandler(IStateRepository stateRepository, IMapper mapper)
    : IRequestHandler<UpdateStateCommand, Unit>
{
    public async Task<Unit> Handle(UpdateStateCommand request, CancellationToken cancellationToken)
    {
        var state = mapper.Map<Domain.Common.State>(request);
        await stateRepository.UpdateAsync(state);
        return Unit.Value;
    }
}