using HealthTourist.Domain.Main;

namespace HealthTourist.Domain.Interface;

public class HotelTag
{
    #region Properties

    public int HotelId { get; set; }
    public int TagId { get; set; }

    #endregion

    #region Relations

    public virtual Hotel Hotel { get; set; }
    public virtual Tag Tag { get; set; }

    #endregion
}