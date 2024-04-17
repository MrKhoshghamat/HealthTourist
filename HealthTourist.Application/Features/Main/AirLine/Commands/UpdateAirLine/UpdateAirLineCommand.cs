using MediatR;

namespace HealthTourist.Application.Features.Main.AirLine.Commands.UpdateAirLine;

public class UpdateAirLineCommand : IRequest<Unit>
{
    public string Name { get; set; }
    public string Title { get; set; }
}