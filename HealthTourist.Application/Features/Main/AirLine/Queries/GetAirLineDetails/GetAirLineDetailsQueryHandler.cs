using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using HealthTourist.Common.Exceptions;
using MediatR;

namespace HealthTourist.Application.Features.Main.AirLine.Queries.GetAirLineDetails;

public class GetAirLineDetailsQueryHandler(IAirLineRepository airLineRepository, IMapper mapper)
    : IRequestHandler<GetAirLineDetailsQuery, GetAirLineDetailsDto>
{
    public async Task<GetAirLineDetailsDto> Handle(GetAirLineDetailsQuery request, CancellationToken cancellationToken)
    {
        if (request == null) throw new BadRequestException("Incoming request is not valid");
        var airLine = await airLineRepository.FindAsync(request.Id);
        if (airLine == null) throw new NotFoundException(nameof(Domain.Main.AirLine), request.Id);

        var result = mapper.Map<GetAirLineDetailsDto>(airLine);
        return result;
    }
}