using MediatR;

namespace HealthTourist.Application.Features.Main.Treatment.Commands.DeleteTreatment;

public class DeleteTreatmentCommand : IRequest<Unit>
{
    public int TreatmentTypeId { get; set; }
    public string Name { get; set; }
    public string Title { get; set; }
}

public class DeleteTreatmentByIdCommand(int Id) : IRequest<Unit>;