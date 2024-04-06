using MediatR;

namespace HealthTourist.Application.Features.Main.Health.Queries.GetHealths;

public record GetHealthsQuery : IRequest<List<GetHealthsDto>>;
