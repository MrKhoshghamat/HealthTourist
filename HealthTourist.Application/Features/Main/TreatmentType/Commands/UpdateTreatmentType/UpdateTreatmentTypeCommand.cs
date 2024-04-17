using HealthTourist.Domain.Interface;
using MediatR;

namespace HealthTourist.Application.Features.Main.TreatmentType.Commands.UpdateTreatmentType;

public class UpdateTreatmentTypeCommand : IRequest<Unit>
{
    public string Name { get; set; }
    public string Title { get; set; }
}