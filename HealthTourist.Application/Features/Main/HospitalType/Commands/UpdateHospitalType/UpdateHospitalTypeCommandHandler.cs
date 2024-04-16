using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using MediatR;

namespace HealthTourist.Application.Features.Main.HospitalType.Commands.UpdateHospitalType;

public class UpdateHospitalTypeCommandHandler(IHospitalTypeRepository hospitalTypeRepository, IMapper mapper)
    : IRequestHandler<UpdateHospitalTypeCommand, Unit>
{
    public async Task<Unit> Handle(UpdateHospitalTypeCommand request, CancellationToken cancellationToken)
    {
        var hospitalType = mapper.Map<Domain.Main.HospitalType>(request);
        await hospitalTypeRepository.UpdateAsync(hospitalType);
        return Unit.Value;
    }
}