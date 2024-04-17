using MediatR;

namespace HealthTourist.Application.Features.Main.HospitalType.Commands.UpdateHospitalType;

public class UpdateHospitalTypeCommand : IRequest<Unit>
{
    public string Name { get; set; }
    public string Title { get; set; }
}