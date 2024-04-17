using MediatR;

namespace HealthTourist.Application.Features.Main.Treatment.Commands.CreateTreatment;

public class CreateTreatmentCommand : IRequest<int>
{
    public int TreatmentTypeId { get; set; }
    public string Name { get; set; }
    public string Title { get; set; }
}