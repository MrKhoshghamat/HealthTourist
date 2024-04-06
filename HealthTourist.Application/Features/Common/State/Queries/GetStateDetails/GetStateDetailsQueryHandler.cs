using AutoMapper;
using HealthTourist.Application.Contracts.Common;
using HealthTourist.Common.Exceptions;
using MediatR;

namespace HealthTourist.Application.Features.Common.State.Queries.GetStateDetails;

public class GetStateDetailsQueryHandler(IStateRepository stateRepository, IMapper mapper)
    : IRequestHandler<GetStateDetailsQuery, GetStateDetailsDto>
{
    public async Task<GetStateDetailsDto> Handle(GetStateDetailsQuery request, CancellationToken cancellationToken)
    {
        if (request == null) throw new BadRequestException("Incoming request is not valid");
        var state = await stateRepository.FindAsync(request.Id);
        if (state == null) throw new NotFoundException(nameof(Domain.Common.State), request.Id);

        var result = mapper.Map<GetStateDetailsDto>(state);
        return result;
    }
}