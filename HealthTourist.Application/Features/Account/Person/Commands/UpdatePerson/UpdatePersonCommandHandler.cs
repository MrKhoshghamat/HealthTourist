using AutoMapper;
using HealthTourist.Application.Contracts.Account;
using MediatR;

namespace HealthTourist.Application.Features.Account.Person.Commands.UpdatePerson;

public class UpdatePersonCommandHandler(IPersonRepository personRepository, IMapper mapper)
    : IRequestHandler<UpdatePersonCommand, Unit>
{
    public async Task<Unit> Handle(UpdatePersonCommand request, CancellationToken cancellationToken)
    {
        var person = mapper.Map<Domain.Account.Person>(request);
        await personRepository.UpdateAsync(person);
        return Unit.Value;
    }
}