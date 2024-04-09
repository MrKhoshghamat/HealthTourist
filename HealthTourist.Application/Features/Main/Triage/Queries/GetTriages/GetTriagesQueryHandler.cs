using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using HealthTourist.Common.Exceptions;
using MediatR;

namespace HealthTourist.Application.Features.Main.Triage.Queries.GetTriages;

public class GetTriagesQueryHandler(ITriageRepository triageRepository, IMapper mapper)
    : IRequestHandler<GetTriagesQuery, List<GetTriagesDto>>
{
    public async Task<List<GetTriagesDto>> Handle(GetTriagesQuery request, CancellationToken cancellationToken)
    {
        if (request == null) throw new BadRequestException("Incoming request is not valid");
        var triages = await triageRepository.GetAllAsync();
        if (triages == null) throw new NotFoundException(nameof(List<Domain.Main.Triage>), request);

        var result = mapper.Map<List<GetTriagesDto>>(triages);
        return result;
    }
}