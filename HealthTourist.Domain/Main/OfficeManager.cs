using HealthTourist.Domain.Account;

namespace HealthTourist.Domain.Main;

public class OfficeManager : BaseEntity<long>
{
    #region Properties

    public long PersonId { get; set; }
    public int OfficeId { get; set; }

    #endregion

    #region Relations

    public virtual Person Person { get; set; }
    public virtual Office Office { get; set; }

    #endregion
}