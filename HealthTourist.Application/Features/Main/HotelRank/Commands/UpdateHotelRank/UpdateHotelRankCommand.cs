using MediatR;

namespace HealthTourist.Application.Features.Main.HotelRank.Commands.UpdateHotelRank;

public class UpdateHotelRankCommand : IRequest<Unit>
{
    #region Properties

    public int HotelTypeId { get; set; }
    public string Title { get; set; }

    #endregion

    #region Relations

    public virtual Domain.Main.HotelType HotelType { get; set; }
    public virtual ICollection<Domain.Main.Hotel> Hotels { get; set; }

    #endregion
}