using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using MediatR;

namespace HealthTourist.Application.Features.Main.TreatmentType.Commands.CreateTreatmentType;

public class CreateTreatmentTypeCommandHandler(ITreatmentTypeRepository treatmentTypeRepository, IMapper mapper)
    : IRequestHandler<CreateTreatmentTypeCommand, int>
{
    public async Task<int> Handle(CreateTreatmentTypeCommand request, CancellationToken cancellationToken)
    {
        try
        {
            var treatmentType = mapper.Map<Domain.Main.TreatmentType>(request);
            await treatmentTypeRepository.CreateAsync(treatmentType);
            return treatmentType.Id;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}