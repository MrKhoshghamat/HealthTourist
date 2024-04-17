using MediatR;

namespace HealthTourist.Application.Features.Main.HospitalType.Commands.CreateHospitalType;

public class CreateHospitalTypeCommand : IRequest<int>
{
    public string Name { get; set; }
    public string Title { get; set; }
}