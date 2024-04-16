using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using MediatR;

namespace HealthTourist.Application.Features.Main.Treatment.Commands.CreateTreatment;

public class CreateTreatmentCommandHandler(ITreatmentRepository treatmentRepository, IMapper mapper)
    : IRequestHandler<CreateTreatmentCommand, int>
{
    public async Task<int> Handle(CreateTreatmentCommand request, CancellationToken cancellationToken)
    {
        var treatment = mapper.Map<Domain.Main.Treatment>(request);
        await treatmentRepository.CreateAsync(treatment);
        return treatment.Id;
    }
}