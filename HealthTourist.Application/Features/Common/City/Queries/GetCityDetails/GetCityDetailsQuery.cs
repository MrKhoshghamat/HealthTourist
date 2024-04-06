using MediatR;

namespace HealthTourist.Application.Features.Common.City.Queries.GetCityDetails;

public record GetCityDetailsQuery(int Id) : IRequest<GetCityDetailsDto>;
