using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using MediatR;

namespace HealthTourist.Application.Features.Main.Hospital.Commands.DeleteHospital;

public class DeleteHospitalCommandHandler(IHospitalRepository hospitalRepository, IMapper mapper)
    : IRequestHandler<DeleteHospitalCommand, Unit>
{
    public async Task<Unit> Handle(DeleteHospitalCommand request, CancellationToken cancellationToken)
    {
        var hospital = mapper.Map<Domain.Main.Hospital>(request);
        await hospitalRepository.DeleteAsync(hospital);
        return Unit.Value;
    }
    
    public async Task<Unit> Handle(DeleteHospitalByIdCommand request, CancellationToken cancellationToken)
    {
        await hospitalRepository.DeleteAsync(request.Id);
        return Unit.Value;
    }
}