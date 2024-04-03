using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using HealthTourist.Common.Exceptions;
using MediatR;

namespace HealthTourist.Application.Features.Main.TreatmentType.Queries.GetTreatmentTypeDetails;

public class GetTreatmentTypeDetailsQueryHandler(ITreatmentTypeRepository treatmentTypeRepository, IMapper mapper)
    : IRequestHandler<GetTreatmentTypeDetailsQuery, GetTreatmentTypeDetailsDto>
{
    public async Task<GetTreatmentTypeDetailsDto> Handle(GetTreatmentTypeDetailsQuery request,
        CancellationToken cancellationToken)
    {
        if (request == null) throw new BadRequestException("Incoming request is not valid");
        var treatmentType = await treatmentTypeRepository.FindAsync(request.Id);
        if (treatmentType == null) throw new NotFoundException(nameof(Domain.Main.TreatmentType), request.Id);

        var result = mapper.Map<GetTreatmentTypeDetailsDto>(treatmentType);
        return result;
    }
}