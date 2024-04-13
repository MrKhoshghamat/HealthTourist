namespace HealthTourist.Domain.Main;

public class HotelRank : BaseEntity<int>
{
    #region Properties

    public int HotelTypeId { get; set; }
    public string Title { get; set; }

    #endregion

    #region Relations

    public virtual HotelType HotelType { get; set; }
    public virtual ICollection<Hotel> Hotels { get; set; }

    #endregion
}