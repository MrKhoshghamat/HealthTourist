using AutoMapper;
using HealthTourist.Application.Contracts.Account;
using HealthTourist.Common.Exceptions;
using MediatR;

namespace HealthTourist.Application.Features.Account.Person.Queries.GetPersons;

public class GetPersonsQueryHandler(IPersonRepository personRepository, IMapper mapper)
    : IRequestHandler<GetPersonsQuery, List<GetPersonsDto>>
{
    #region Handler

    public async Task<List<GetPersonsDto>> Handle(GetPersonsQuery request, CancellationToken cancellationToken)
    {
        // Fetch required data and check for null
        var persons = await personRepository.GetAllAsync();
        if (persons == null) throw new NotFoundException(nameof(List<Domain.Account.Person>), request);

        // Map fetched data to required result and return
        var result = mapper.Map<List<GetPersonsDto>>(persons);
        return result;
    }

    #endregion
}