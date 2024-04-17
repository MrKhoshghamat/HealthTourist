using MediatR;

namespace HealthTourist.Application.Features.Main.HotelType.Commands.CreateHotelType;

public class CreateHotelTypeCommand : IRequest<int>
{
    public string Name { get; set; }
    public string Title { get; set; }
}