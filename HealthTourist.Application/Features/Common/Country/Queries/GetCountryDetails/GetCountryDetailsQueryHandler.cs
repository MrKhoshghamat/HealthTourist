using AutoMapper;
using HealthTourist.Application.Contracts.Common;
using HealthTourist.Common.Exceptions;
using MediatR;

namespace HealthTourist.Application.Features.Common.Country.Queries.GetCountryDetails;

public class GetCountryDetailsQueryHandler(ICountryRepository countryRepository, IMapper mapper)
    : IRequestHandler<GetCountryDetailsQuery, GetCountryDetailsDto>
{
    public async Task<GetCountryDetailsDto> Handle(GetCountryDetailsQuery request, CancellationToken cancellationToken)
    {
        if (request == null) throw new BadRequestException("Incoming request is not valid");
        var country = await countryRepository.FindAsync(request.Id);
        if (country == null) throw new NotFoundException(nameof(Domain.Common.Country), request.Id);

        var result = mapper.Map<GetCountryDetailsDto>(country);
        return result;
    }
}