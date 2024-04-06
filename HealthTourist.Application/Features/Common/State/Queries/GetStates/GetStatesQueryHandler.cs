using AutoMapper;
using HealthTourist.Application.Contracts.Common;
using HealthTourist.Common.Exceptions;
using MediatR;

namespace HealthTourist.Application.Features.Common.State.Queries.GetStates;

public class GetStatesQueryHandler(IStateRepository stateRepository, IMapper mapper)
    : IRequestHandler<GetStatesQuery, List<GetStatesDto>>
{
    public async Task<List<GetStatesDto>> Handle(GetStatesQuery request, CancellationToken cancellationToken)
    {
        if (request == null) throw new BadRequestException("Incoming request is not valid");
        var states = await stateRepository.GetAllAsync();
        if (states == null) throw new NotFoundException(nameof(List<Domain.Common.State>), request);

        var result = mapper.Map<List<GetStatesDto>>(states);
        return result;
    }
}