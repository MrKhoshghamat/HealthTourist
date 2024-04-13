using MediatR;

namespace HealthTourist.Application.Features.Main.Sightseen.Queries.GetSightseensByCityName;

public record GetSightseensByCityNameQuery(string CityName) : IRequest<List<GetSightseensByCityNameDto>>;
