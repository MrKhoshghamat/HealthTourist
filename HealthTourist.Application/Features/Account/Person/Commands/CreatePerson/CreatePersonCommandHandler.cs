using AutoMapper;
using HealthTourist.Application.Contracts.Account;
using MediatR;

namespace HealthTourist.Application.Features.Account.Person.Commands.CreatePerson;

public class CreatePersonCommandHandler(IPersonRepository personRepository, IMapper mapper)
    : IRequestHandler<CreatePersonCommand, long>
{
    public async Task<long> Handle(CreatePersonCommand request, CancellationToken cancellationToken)
    {
        var person = mapper.Map<Domain.Account.Person>(request);
        await personRepository.CreateAsync(person);
        return person.Id;
    }
}