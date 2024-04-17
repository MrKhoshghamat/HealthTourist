using MediatR;

namespace HealthTourist.Application.Features.Main.HotelRank.Commands.UpdateHotelRank;

public class UpdateHotelRankCommand : IRequest<Unit>
{
    public int HotelTypeId { get; set; }
    public string Title { get; set; }
}