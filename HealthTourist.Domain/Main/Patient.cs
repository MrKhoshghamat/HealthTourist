using HealthTourist.Domain.Account;

namespace HealthTourist.Domain.Main;

public class Patient : BaseEntity<long>
{
    #region Properties

    public long PersonId { get; set; }
    public string Height { get; set; }
    public string Weight { get; set; }

    #endregion

    #region Relations

    public virtual Person Person { get; set; }
    public virtual ICollection<Travel> Travels { get; set; }
    public virtual ICollection<Triage> Triages { get; set; }

    #endregion
}