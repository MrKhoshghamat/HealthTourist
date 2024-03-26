using HealthTourist.Domain.Account;
using HealthTourist.Domain.Interface;

namespace HealthTourist.Domain.Main;

public class Guest : BaseEntity<long>
{
    #region Properties

    public long PersonId { get; set; }

    #endregion

    #region Relations

    public virtual Person Person { get; set; }
    public virtual ICollection<TravelGuest> TravelGuests { get; set; }

    #endregion
}