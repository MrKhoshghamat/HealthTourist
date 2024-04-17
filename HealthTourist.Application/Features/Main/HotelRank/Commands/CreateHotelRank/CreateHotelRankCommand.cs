using MediatR;

namespace HealthTourist.Application.Features.Main.HotelRank.Commands.CreateHotelRank;

public class CreateHotelRankCommand : IRequest<int>
{
    public int HotelTypeId { get; set; }
    public string Title { get; set; }
}