using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using HealthTourist.Common.Exceptions;
using MediatR;

namespace HealthTourist.Application.Features.Main.TreatmentType.Queries.GetTreatmentTypes;

public class GetTreatmentTypesQueryHandler(ITreatmentTypeRepository treatmentTypeRepository, IMapper mapper)
    : IRequestHandler<GetTreatmentTypesQuery, List<GetTreatmentTypesDto>>
{
    public async Task<List<GetTreatmentTypesDto>> Handle(GetTreatmentTypesQuery request,
        CancellationToken cancellationToken)
    {
        if (request == null) throw new BadRequestException("Incoming request is not valid");
        var treatmentTypes = await treatmentTypeRepository.GetAllAsync();
        if (treatmentTypes == null) throw new NotFoundException(nameof(List<Domain.Main.TreatmentType>), request);

        var result = mapper.Map<List<GetTreatmentTypesDto>>(treatmentTypes);
        return result;
    }
}