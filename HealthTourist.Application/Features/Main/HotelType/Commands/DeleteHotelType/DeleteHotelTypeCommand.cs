using MediatR;

namespace HealthTourist.Application.Features.Main.HotelType.Commands.DeleteHotelType;

public class DeleteHotelTypeCommand : IRequest<Unit>
{
    public string Name { get; set; }
    public string Title { get; set; }
}