using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using HealthTourist.Common.Exceptions;
using MediatR;

namespace HealthTourist.Application.Features.Main.Sightseen.Queries.GetSightseens;

public class GetSightseensQueryHandler(ISightseenRepository sightseenRepository, IMapper mapper)
: IRequestHandler<GetSightseensQuery, List<GetSightseensDto>>
{
    public async Task<List<GetSightseensDto>> Handle(GetSightseensQuery request, CancellationToken cancellationToken)
    {
        if (request == null) throw new BadRequestException("Incoming request is not valid");
        var sightseens = await sightseenRepository.GetAllAsync();
        if (sightseens == null) throw new NotFoundException(nameof(List<Domain.Main.Sightseen>), request);

        var result = mapper.Map<List<GetSightseensDto>>(sightseens);
        return result;
    }
}