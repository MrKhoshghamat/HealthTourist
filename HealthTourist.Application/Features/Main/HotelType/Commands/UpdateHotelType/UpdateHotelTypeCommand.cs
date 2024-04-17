using MediatR;

namespace HealthTourist.Application.Features.Main.HotelType.Commands.UpdateHotelType;

public class UpdateHotelTypeCommand : IRequest<Unit>
{
    public string Name { get; set; }
    public string Title { get; set; }
}