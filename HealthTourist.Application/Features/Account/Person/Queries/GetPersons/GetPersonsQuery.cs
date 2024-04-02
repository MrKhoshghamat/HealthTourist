using MediatR;

namespace HealthTourist.Application.Features.Account.Person.Queries.GetPersons;

public record GetPersonsQuery : IRequest<List<GetPersonsDto>>;
