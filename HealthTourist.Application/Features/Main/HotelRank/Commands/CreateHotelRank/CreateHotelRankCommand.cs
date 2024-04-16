using MediatR;

namespace HealthTourist.Application.Features.Main.HotelRank.Commands.CreateHotelRank;

public class CreateHotelRankCommand : IRequest<int>
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