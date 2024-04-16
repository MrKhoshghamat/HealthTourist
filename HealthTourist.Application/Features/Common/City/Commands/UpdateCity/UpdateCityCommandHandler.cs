using AutoMapper;
using HealthTourist.Application.Contracts.Common;
using MediatR;

namespace HealthTourist.Application.Features.Common.City.Commands.UpdateCity;

public class UpdateCityCommandHandler(ICityRepository cityRepository, IMapper mapper)
    : IRequestHandler<UpdateCityCommand, Unit>
{
    public async Task<Unit> Handle(UpdateCityCommand request, CancellationToken cancellationToken)
    {
        var city = mapper.Map<Domain.Common.City>(request);
        await cityRepository.UpdateAsync(city);
        return Unit.Value;
    }
}