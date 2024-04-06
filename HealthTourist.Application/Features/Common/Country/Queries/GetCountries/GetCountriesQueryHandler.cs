using AutoMapper;
using HealthTourist.Application.Contracts.Common;
using HealthTourist.Common.Exceptions;
using MediatR;

namespace HealthTourist.Application.Features.Common.Country.Queries.GetCountries;

public class GetCountriesQueryHandler(ICountryRepository countryRepository, IMapper mapper)
    : IRequestHandler<GetCountriesQuery, List<GetCountriesDto>>
{
    public async Task<List<GetCountriesDto>> Handle(GetCountriesQuery request, CancellationToken cancellationToken)
    {
        if (request == null) throw new BadRequestException("Incoming request is not valid");
        var countries = await countryRepository.GetAllAsync();
        if (countries == null) throw new NotFoundException(nameof(List<Domain.Common.Country>), request);

        var result = mapper.Map<List<GetCountriesDto>>(countries);
        return result;
    }
}