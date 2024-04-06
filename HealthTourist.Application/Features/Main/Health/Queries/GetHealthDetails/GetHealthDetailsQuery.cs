using MediatR;

namespace HealthTourist.Application.Features.Main.Health.Queries.GetHealthDetails;

public record GetHealthDetailsQuery(Guid Id) : IRequest<GetHealthDetailsDto>;