using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using HealthTourist.Common.Exceptions;
using MediatR;

namespace HealthTourist.Application.Features.Main.AirLine.Queries.GetAirLines;

public class GetAirLinesQueryHandler(IAirLineRepository airLineRepository, IMapper mapper)
    : IRequestHandler<GetAirLinesQuery, List<GetAirLinesDto>>
{
    public async Task<List<GetAirLinesDto>> Handle(GetAirLinesQuery request, CancellationToken cancellationToken)
    {
        if (request == null) throw new BadRequestException("Incoming request is not valid");
        var airLines = await airLineRepository.GetAllAsync();
        if (airLines == null) throw new NotFoundException(nameof(List<Domain.Main.AirLine>), request);

        var result = mapper.Map<List<GetAirLinesDto>>(airLines);
        return result;
    }
}