using HealthTourist.Domain.Main;

namespace HealthTourist.Domain.Interface;

public class TravelGuest
{
    #region Properties

    public Guid TravelId { get; set; }
    public long GuestId { get; set; }

    #endregion

    #region Relations

    public virtual Travel Travel { get; set; }
    public virtual Guest Guest { get; set; }

    #endregion
}