using MediatR;

namespace HealthTourist.Application.Features.Main.HotelRank.Commands.DeleteHotelRank;

public class DeleteHotelRankCommand : IRequest<Unit>
{
    public int HotelTypeId { get; set; }
    public string Title { get; set; }
}