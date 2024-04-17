using MediatR;

namespace HealthTourist.Application.Features.Main.AirLine.Commands.DeleteAirLine;

public class DeleteAirLineCommand : IRequest<Unit>
{
    public string Name { get; set; }
    public string Title { get; set; }
}

public record DeleteAirLineByIdCommand(int Id) : IRequest<Unit>;