using MediatR;

namespace HealthTourist.Application.Features.Main.HospitalType.Commands.DeleteHospitalType;

public class DeleteHospitalTypeCommand : IRequest<Unit>
{
    public string Name { get; set; }
    public string Title { get; set; }
}

public record DeleteHospitalTypeByIdCommand(int Id) : IRequest<Unit>;