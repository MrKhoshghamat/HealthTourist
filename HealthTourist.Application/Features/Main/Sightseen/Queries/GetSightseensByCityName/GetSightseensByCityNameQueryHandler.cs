using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using HealthTourist.Common.Exceptions;
using MediatR;

namespace HealthTourist.Application.Features.Main.Sightseen.Queries.GetSightseensByCityName;

public class GetSightseensByCityNameQueryHandler(ISightseenRepository sightseenRepository, IMapper mapper)
    : IRequestHandler<GetSightseensByCityNameQuery, List<GetSightseensByCityNameDto>>
{
    public async Task<List<GetSightseensByCityNameDto>> Handle(GetSightseensByCityNameQuery request,
        CancellationToken cancellationToken)
    {
        if (request == null) throw new BadRequestException("Incoming request is not valid");
        var sightseens = await sightseenRepository.GetAllAsync(s => s.City.Name == request.CityName);
        if (sightseens == null) throw new NotFoundException(nameof(List<Domain.Main.Sightseen>), request.CityName);

        var result = mapper.Map<List<GetSightseensByCityNameDto>>(sightseens);
        return result;
    }
}