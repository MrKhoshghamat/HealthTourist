namespace HealthTourist.Domain.Main;

public class HotelType : BaseEntity<int>
{
    #region Properties

    public string Name { get; set; }
    public string Title { get; set; }

    #endregion

    #region Relations

    public virtual ICollection<HotelRank> HotelRanks { get; set; }

    #endregion
}