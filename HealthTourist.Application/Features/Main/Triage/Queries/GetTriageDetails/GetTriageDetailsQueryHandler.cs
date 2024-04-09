using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using HealthTourist.Common.Exceptions;
using MediatR;

namespace HealthTourist.Application.Features.Main.Triage.Queries.GetTriageDetails;

public class GetTriageDetailsQueryHandler(ITriageRepository triageRepository, IMapper mapper)
    : IRequestHandler<GetTriageDetailsQuery, GetTriageDetailsDto>
{
    public async Task<GetTriageDetailsDto> Handle(GetTriageDetailsQuery request, CancellationToken cancellationToken)
    {
        if (request == null) throw new BadRequestException("Incoming request is not valid");
        var triage = await triageRepository.FindAsync(request.Id);
        if (triage == null) throw new NotFoundException(nameof(Domain.Main.Triage), request.Id);

        var result = mapper.Map<GetTriageDetailsDto>(triage);
        return result;
    }
}