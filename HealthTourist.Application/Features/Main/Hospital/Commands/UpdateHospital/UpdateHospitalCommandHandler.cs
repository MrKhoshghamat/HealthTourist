using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using MediatR;

namespace HealthTourist.Application.Features.Main.Hospital.Commands.UpdateHospital;

public class UpdateHospitalCommandHandler(IHospitalRepository hospitalRepository, IMapper mapper)
    : IRequestHandler<UpdateHospitalCommand, Unit>
{
    public async Task<Unit> Handle(UpdateHospitalCommand request, CancellationToken cancellationToken)
    {
        var hospital = mapper.Map<Domain.Main.Hospital>(request);
        await hospitalRepository.UpdateAsync(hospital);
        return Unit.Value;
    }
}