using HealthTourist.Domain.Main;

namespace HealthTourist.Application.Features.Main.HotelRank.Queries.GetHotelRankDetails;

public class GetHotelRankDetailsDto
{
    #region Properties

    public int HotelTypeId { get; set; }

    #endregion

    #region Relations

    public virtual Domain.Main.HotelType HotelType { get; set; }
    public virtual ICollection<Domain.Main.Hotel> Hotels { get; set; }

    #endregion
}