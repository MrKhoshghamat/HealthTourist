using AutoMapper;
using HealthTourist.Application.Contracts.Common;
using MediatR;

namespace HealthTourist.Application.Features.Common.Country.Commands.UpdateCountry;

public class UpdateCountryCommandHandler(ICountryRepository countryRepository, IMapper mapper)
    : IRequestHandler<UpdateCountryCommand, Unit>
{
    public async Task<Unit> Handle(UpdateCountryCommand request, CancellationToken cancellationToken)
    {
        var country = mapper.Map<Domain.Common.Country>(request);
        await countryRepository.UpdateAsync(country);
        return Unit.Value;
    }
}