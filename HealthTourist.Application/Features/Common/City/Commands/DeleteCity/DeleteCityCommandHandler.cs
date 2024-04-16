using AutoMapper;
using HealthTourist.Application.Contracts.Common;
using MediatR;

namespace HealthTourist.Application.Features.Common.City.Commands.DeleteCity;

public class DeleteCityCommandHandler(ICityRepository cityRepository, IMapper mapper)
: IRequestHandler<DeleteCityCommand, Unit>
{
    public async Task<Unit> Handle(DeleteCityCommand request, CancellationToken cancellationToken)
    {
        var city = mapper.Map<Domain.Common.City>(request);
        await cityRepository.DeleteAsync(city);
        return Unit.Value;
    }
}