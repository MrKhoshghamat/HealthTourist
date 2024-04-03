using MediatR;

namespace HealthTourist.Application.Features.Account.Person.Queries.GetPersonDetails;

public record GetPersonDetailsQuery(long Id) : IRequest<GetPersonDetailsDto>;