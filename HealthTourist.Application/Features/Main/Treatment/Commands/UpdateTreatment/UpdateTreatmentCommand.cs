using MediatR;

namespace HealthTourist.Application.Features.Main.Treatment.Commands.UpdateTreatment;

public class UpdateTreatmentCommand : IRequest<Unit>
{
    public int TreatmentTypeId { get; set; }
    public string Name { get; set; }
    public string Title { get; set; }
}