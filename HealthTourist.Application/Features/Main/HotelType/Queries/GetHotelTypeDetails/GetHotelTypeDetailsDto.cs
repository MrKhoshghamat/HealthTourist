namespace HealthTourist.Application.Features.Main.HotelType.Queries.GetHotelTypeDetails;

public class GetHotelTypeDetailsDto
{
    #region Properties

    public string Name { get; set; }
    public string Title { get; set; }

    #endregion

    #region Relations

    public virtual ICollection<Domain.Main.HotelRank> HotelRanks { get; set; }

    #endregion
}