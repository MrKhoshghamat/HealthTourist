using MediatR;

namespace HealthTourist.Application.Features.Main.AirLine.Commands.CreateAirLine;

public class CreateAirLineCommand : IRequest<int>
{
    public string Name { get; set; }
    public string Title { get; set; }
}