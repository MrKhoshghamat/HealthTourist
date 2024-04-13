using MediatR;

namespace HealthTourist.Application.Features.Main.Sightseen.Queries.GetSightseens;

public record GetSightseensQuery : IRequest<List<GetSightseensDto>>;
