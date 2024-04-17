using HealthTourist.Domain.Interface;
using MediatR;

namespace HealthTourist.Application.Features.Main.TreatmentType.Commands.CreateTreatmentType;

public class CreateTreatmentTypeCommand : IRequest<int>
{
    public string Name { get; set; }
    public string Title { get; set; }
}