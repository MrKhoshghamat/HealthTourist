using AutoMapper;
using HealthTourist.Application.Contracts.Common;
using HealthTourist.Common.Exceptions;
using MediatR;

namespace HealthTourist.Application.Features.Common.City.Queries.GetCities;

public class GetCitiesQueryHandler(ICityRepository cityRepository, IMapper mapper)
    : IRequestHandler<GetCitiesQuery, List<GetCitiesDto>>
{
    public async Task<List<GetCitiesDto>> Handle(GetCitiesQuery request, CancellationToken cancellationToken)
    {
        if (request == null) throw new BadRequestException("Incoming request is not valid");
        var cities = await cityRepository.GetAllAsync();
        if (cities == null) throw new NotFoundException(nameof(List<Domain.Common.City>), request);

        var result = mapper.Map<List<GetCitiesDto>>(cities);
        return result;
    }
}