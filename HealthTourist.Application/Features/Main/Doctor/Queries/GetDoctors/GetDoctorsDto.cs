using HealthTourist.Domain.Account;
using HealthTourist.Domain.Main;

namespace HealthTourist.Application.Features.Main.Doctor.Queries.GetDoctors;

public class GetDoctorsDto
{
    #region Properties

    public long PersonId { get; set; }
    public int HospitalId { get; set; }
    public int TreatmentId { get; set; }

    #endregion

    #region Relations

    public virtual Person Person { get; set; }
    public virtual Domain.Main.Hospital Hospital { get; set; }
    public virtual Domain.Main.Treatment Treatment { get; set; }
    public virtual ICollection<Domain.Main.Health> Healths { get; set; }
    public virtual ICollection<Domain.Main.TeamMember> TeamMembers { get; set; }

    #endregion
}