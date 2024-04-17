using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using MediatR;

namespace HealthTourist.Application.Features.Main.HospitalType.Commands.DeleteHospitalType;

public class DeleteHospitalTypeCommandHandler(IHospitalTypeRepository hospitalTypeRepository, IMapper mapper)
    : IRequestHandler<DeleteHospitalTypeCommand, Unit>
{
    public async Task<Unit> Handle(DeleteHospitalTypeCommand request, CancellationToken cancellationToken)
    {
        var hospitalType = mapper.Map<Domain.Main.HospitalType>(request);
        await hospitalTypeRepository.DeleteAsync(hospitalType);
        return Unit.Value;
    }
    
    public async Task<Unit> Handle(DeleteHospitalTypeByIdCommand request, CancellationToken cancellationToken)
    {
        var hospitalType = mapper.Map<Domain.Main.HospitalType>(request);
        await hospitalTypeRepository.DeleteAsync(hospitalType);
        return Unit.Value;
    }
}