using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using MediatR;

namespace HealthTourist.Application.Features.Main.TreatmentType.Commands.DeleteTreatmentType;

public class DeleteTreatmentTypeCommandHandler(ITreatmentTypeRepository treatmentTypeRepository, IMapper mapper)
    : IRequestHandler<DeleteTreatmentTypeCommand, Unit>
{
    public async Task<Unit> Handle(DeleteTreatmentTypeCommand request, CancellationToken cancellationToken)
    {
        var treatmentType = mapper.Map<Domain.Main.TreatmentType>(request);
        await treatmentTypeRepository.DeleteAsync(treatmentType);
        return Unit.Value;
    }
    
    public async Task<Unit> Handle(DeleteTreatmentTypeByIdCommand request, CancellationToken cancellationToken)
    {
        var treatmentType = mapper.Map<Domain.Main.TreatmentType>(request);
        await treatmentTypeRepository.DeleteAsync(treatmentType);
        return Unit.Value;
    }
}