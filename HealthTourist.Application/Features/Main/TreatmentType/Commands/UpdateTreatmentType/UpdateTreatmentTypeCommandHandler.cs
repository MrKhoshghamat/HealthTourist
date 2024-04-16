using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using MediatR;

namespace HealthTourist.Application.Features.Main.TreatmentType.Commands.UpdateTreatmentType;

public class UpdateTreatmentTypeCommandHandler(ITreatmentTypeRepository treatmentTypeRepository, IMapper mapper)
    : IRequestHandler<UpdateTreatmentTypeCommand, Unit>
{
    public async Task<Unit> Handle(UpdateTreatmentTypeCommand request, CancellationToken cancellationToken)
    {
        var treatmentType = mapper.Map<Domain.Main.TreatmentType>(request);
        await treatmentTypeRepository.UpdateAsync(treatmentType);
        return Unit.Value;
    }
}