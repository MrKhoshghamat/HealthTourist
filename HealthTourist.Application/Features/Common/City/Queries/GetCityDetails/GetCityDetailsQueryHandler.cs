using AutoMapper;
using HealthTourist.Application.Contracts.Common;
using HealthTourist.Common.Exceptions;
using MediatR;

namespace HealthTourist.Application.Features.Common.City.Queries.GetCityDetails;

public class GetCityDetailsQueryHandler(ICityRepository cityRepository, IMapper mapper)
    : IRequestHandler<GetCityDetailsQuery, GetCityDetailsDto>
{
    public async Task<GetCityDetailsDto> Handle(GetCityDetailsQuery request, CancellationToken cancellationToken)
    {
        if (request == null) throw new BadRequestException("Incoming request is not valid");
        var city = await cityRepository.FindAsync(request.Id);
        if (city == null) throw new NotFoundException(nameof(Domain.Common.City), request.Id);

        var result = mapper.Map<GetCityDetailsDto>(city);
        return result;
    }
}