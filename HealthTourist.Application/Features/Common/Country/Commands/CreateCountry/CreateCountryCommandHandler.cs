using AutoMapper;
using HealthTourist.Application.Contracts.Common;
using MediatR;

namespace HealthTourist.Application.Features.Common.Country.Commands.CreateCountry;

public class CreateCountryCommandHandler(ICountryRepository countryRepository, IMapper mapper)
    : IRequestHandler<CreateCountryCommand, int>
{
    public async Task<int> Handle(CreateCountryCommand request, CancellationToken cancellationToken)
    {
        var country = mapper.Map<Domain.Common.Country>(request);
        await countryRepository.CreateAsync(country);
        return country.Id;
    }
}