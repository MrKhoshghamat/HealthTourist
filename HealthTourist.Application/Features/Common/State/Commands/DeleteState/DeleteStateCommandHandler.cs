using AutoMapper;
using HealthTourist.Application.Contracts.Common;
using MediatR;

namespace HealthTourist.Application.Features.Common.State.Commands.DeleteState;

public class DeleteStateCommandHandler(IStateRepository stateRepository, IMapper mapper)
    : IRequestHandler<DeleteStateCommand, Unit>
{
    public async Task<Unit> Handle(DeleteStateCommand request, CancellationToken cancellationToken)
    {
        var state = mapper.Map<Domain.Common.State>(request);
        await stateRepository.DeleteAsync(state);
        return Unit.Value;
    }
}