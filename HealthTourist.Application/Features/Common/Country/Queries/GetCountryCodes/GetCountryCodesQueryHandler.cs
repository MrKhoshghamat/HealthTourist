using AutoMapper;
using HealthTourist.Application.Contracts.Common;
using HealthTourist.Common.Exceptions;
using MediatR;

namespace HealthTourist.Application.Features.Common.Country.Queries.GetCountryCodes;

public class GetCountryCodesQueryHandler(ICountryRepository countryRepository, IMapper mapper)
    : IRequestHandler<GetCountryCodesQuery, GetCountryCodesDto>
{
    public async Task<GetCountryCodesDto> Handle(GetCountryCodesQuery request, CancellationToken cancellationToken)
    {
        if (request == null) throw new BadRequestException("Incoming request is not valid");
        var countryCodes = await countryRepository.GetAllAsync();
        if (countryCodes == null) throw new NotFoundException(nameof(List<Domain.Common.Country>), request);

        var result = new GetCountryCodesDto()
        {
            Codes = countryCodes.Select(code => code.Code).ToList()
        };
        
        return result;
    }
}