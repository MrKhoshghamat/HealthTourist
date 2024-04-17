using AutoMapper;
using HealthTourist.Application.Contracts.Account;
using MediatR;

namespace HealthTourist.Application.Features.Account.Person.Commands.DeletePerson;

public class DeletePersonCommandHandler(IPersonRepository personRepository, IMapper mapper)
    : IRequestHandler<DeletePersonCommand, Unit>
{
    public async Task<Unit> Handle(DeletePersonCommand request, CancellationToken cancellationToken)
    {
        var person = mapper.Map<Domain.Account.Person>(request);
        await personRepository.DeleteAsync(person);
        return Unit.Value;
    }
    
    public async Task<Unit> Handle(DeletePersonByIdCommand request, CancellationToken cancellationToken)
    {
        await personRepository.DeleteAsync(request.Id);
        return Unit.Value;
    }
}