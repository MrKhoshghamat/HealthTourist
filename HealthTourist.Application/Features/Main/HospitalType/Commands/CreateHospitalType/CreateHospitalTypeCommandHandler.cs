using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using MediatR;

namespace HealthTourist.Application.Features.Main.HospitalType.Commands.CreateHospitalType;

public class CreateHospitalTypeCommandHandler(IHospitalTypeRepository hospitalTypeRepository, IMapper mapper)
    : IRequestHandler<CreateHospitalTypeCommand, int>
{
    public async Task<int> Handle(CreateHospitalTypeCommand request, CancellationToken cancellationToken)
    {
        var hospitalType = mapper.Map<Domain.Main.HospitalType>(request);
        await hospitalTypeRepository.CreateAsync(hospitalType);
        return hospitalType.Id;
    }
}