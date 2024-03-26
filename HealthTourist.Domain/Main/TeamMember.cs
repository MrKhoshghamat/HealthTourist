using HealthTourist.Domain.Account;

namespace HealthTourist.Domain.Main;

public class TeamMember : BaseEntity<long>
{
    #region Properties

    public long PersonId { get; set; }
    public long DoctorId { get; set; }
    public int TreatmentId { get; set; }

    #endregion

    #region Relations

    public virtual Person Person { get; set; }
    public virtual Doctor Doctor { get; set; }
    public virtual Treatment Treatment { get; set; }

    #endregion
}