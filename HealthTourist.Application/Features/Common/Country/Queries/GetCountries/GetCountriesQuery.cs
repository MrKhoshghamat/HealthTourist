using MediatR;

namespace HealthTourist.Application.Features.Common.Country.Queries.GetCountries;

public record GetCountriesQuery(int Id) : IRequest<List<GetCountriesDto>>;