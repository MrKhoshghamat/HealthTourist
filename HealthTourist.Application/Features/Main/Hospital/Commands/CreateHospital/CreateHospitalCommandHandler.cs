using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using MediatR;

namespace HealthTourist.Application.Features.Main.Hospital.Commands.CreateHospital;

public class CreateHospitalCommandHandler(IHospitalRepository hospitalRepository, IMapper mapper)
    : IRequestHandler<CreateHospitalCommand, int>
{
    public async Task<int> Handle(CreateHospitalCommand request, CancellationToken cancellationToken)
    {
        var hospital = mapper.Map<Domain.Main.Hospital>(request);
        await hospitalRepository.CreateAsync(hospital);
        return hospital.Id;
    }
}