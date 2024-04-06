using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using HealthTourist.Common.Exceptions;
using MediatR;

namespace HealthTourist.Application.Features.Main.Health.Queries.GetHealths;

public class GetHealthsQueryHandler(IHealthRepository healthRepository, IMapper mapper)
    : IRequestHandler<GetHealthsQuery, List<GetHealthsDto>>
{
    public async Task<List<GetHealthsDto>> Handle(GetHealthsQuery request, CancellationToken cancellationToken)
    {
        if (request == null) throw new BadRequestException("Incoming request is not valid");
        var healths = await healthRepository.GetAllAsync();
        if (healths == null) throw new NotFoundException(nameof(List<Domain.Main.Health>), request);

        var result = mapper.Map<List<GetHealthsDto>>(healths);
        return result;
    }
}