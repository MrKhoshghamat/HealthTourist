using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using HealthTourist.Common.Exceptions;
using MediatR;

namespace HealthTourist.Application.Features.Main.Health.Queries.GetHealthDetails;

public class GetHealthDetailsQueryHandler(IHealthRepository healthRepository, IMapper mapper)
    : IRequestHandler<GetHealthDetailsQuery, GetHealthDetailsDto>
{
    public async Task<GetHealthDetailsDto> Handle(GetHealthDetailsQuery request, CancellationToken cancellationToken)
    {
        if (request == null) throw new BadRequestException("Incoming request is not valid");
        var health = await healthRepository.FindAsync(request.Id);
        if (health == null) throw new NotFoundException(nameof(Domain.Main.Health), request.Id);

        var result = mapper.Map<GetHealthDetailsDto>(health);
        return result;
    }
}