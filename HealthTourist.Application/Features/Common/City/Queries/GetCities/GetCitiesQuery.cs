using MediatR;

namespace HealthTourist.Application.Features.Common.City.Queries.GetCities;

public record GetCitiesQuery : IRequest<List<GetCitiesDto>>;