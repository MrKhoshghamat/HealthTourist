using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using MediatR;

namespace HealthTourist.Application.Features.Main.Treatment.Commands.DeleteTreatment;

public class DeleteTreatmentCommandHandler(ITreatmentRepository treatmentRepository, IMapper mapper)
    : IRequestHandler<DeleteTreatmentCommand, Unit>
{
    public async Task<Unit> Handle(DeleteTreatmentCommand request, CancellationToken cancellationToken)
    {
        var treatment = mapper.Map<Domain.Main.Treatment>(request);
        await treatmentRepository.CreateAsync(treatment);
        return Unit.Value;
    }
}