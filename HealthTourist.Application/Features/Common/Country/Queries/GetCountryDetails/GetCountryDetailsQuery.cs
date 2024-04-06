using MediatR;

namespace HealthTourist.Application.Features.Common.Country.Queries.GetCountryDetails;

public record GetCountryDetailsQuery(int Id) : IRequest<GetCountryDetailsDto>;
