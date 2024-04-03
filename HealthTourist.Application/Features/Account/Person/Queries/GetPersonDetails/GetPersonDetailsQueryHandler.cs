using AutoMapper;
using HealthTourist.Application.Contracts.Account;
using HealthTourist.Common.Exceptions;
using MediatR;

namespace HealthTourist.Application.Features.Account.Person.Queries.GetPersonDetails;

public class GetPersonDetailsQueryHandler(IPersonRepository personRepository, IMapper mapper) 
    : IRequestHandler<GetPersonDetailsQuery, GetPersonDetailsDto>
{
    #region Handler

    public async Task<GetPersonDetailsDto> Handle(GetPersonDetailsQuery request, CancellationToken cancellationToken)
    {
        // Fetch required data and check for null
        var personDetails = await personRepository.FindAsync(request.Id);
        if (personDetails == null) throw new NotFoundException(nameof(Domain.Account.Person), request.Id);

        // Map fetched data to required result and return
        var result = mapper.Map<GetPersonDetailsDto>(personDetails);
        return result;
    }

    #endregion
}