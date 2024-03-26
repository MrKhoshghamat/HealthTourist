using HealthTourist.Domain.Account;

namespace HealthTourist.Domain.Main;

public class Guest : BaseEntity<long>
{
    #region Properties

    public long PersonId { get; set; }

    #endregion

    #region Relations

    public virtual Person Person { get; set; }

    #endregion
}