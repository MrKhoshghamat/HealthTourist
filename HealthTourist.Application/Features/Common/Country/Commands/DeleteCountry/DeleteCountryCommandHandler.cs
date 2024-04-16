using AutoMapper;
using HealthTourist.Application.Contracts.Common;
using MediatR;

namespace HealthTourist.Application.Features.Common.Country.Commands.DeleteCountry;

public class DeleteCountryCommandHandler(ICountryRepository countryRepository, IMapper mapper)
    : IRequestHandler<DeleteCountryCommand, Unit>
{
    public async Task<Unit> Handle(DeleteCountryCommand request, CancellationToken cancellationToken)
    {
        var country = mapper.Map<Domain.Common.Country>(request);
        await countryRepository.DeleteAsync(country);
        return Unit.Value;
    }
}