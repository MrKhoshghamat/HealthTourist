using HealthTourist.Domain.Interface;
using MediatR;

namespace HealthTourist.Application.Features.Main.TreatmentType.Commands.DeleteTreatmentType;

public class DeleteTreatmentTypeCommand : IRequest<Unit>
{
    public string Name { get; set; }
    public string Title { get; set; }
}

public record DeleteTreatmentTypeByIdCommand(int Id) : IRequest<Unit>;