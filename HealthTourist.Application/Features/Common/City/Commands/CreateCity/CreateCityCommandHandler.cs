using AutoMapper;
using HealthTourist.Application.Contracts.Common;
using MediatR;

namespace HealthTourist.Application.Features.Common.City.Commands.CreateCity;

public class CreateCityCommandHandler(ICityRepository cityRepository, IMapper mapper)
    : IRequestHandler<CreateCityCommand, int>
{
    public async Task<int> Handle(CreateCityCommand request, CancellationToken cancellationToken)
    {
        var city = mapper.Map<Domain.Common.City>(request);
        await cityRepository.CreateAsync(city);
        return city.Id;
    }
}