using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using MediatR;

namespace HealthTourist.Application.Features.Main.Treatment.Commands.UpdateTreatment;

public class UpdateTreatmentCommandHandler(ITreatmentRepository treatmentRepository, IMapper mapper)
    : IRequestHandler<UpdateTreatmentCommand, Unit>
{
    public async Task<Unit> Handle(UpdateTreatmentCommand request, CancellationToken cancellationToken)
    {
        var treatment = mapper.Map<Domain.Main.Treatment>(request);
        await treatmentRepository.UpdateAsync(treatment);
        return Unit.Value;
    }
}