using HealthTourist.Domain.Account;
using HealthTourist.Domain.Main;

namespace HealthTourist.Application.Features.Main.Doctor.Queries.GetDoctorDetails;

public class GetDoctorDetailsDto
{
    #region Properties

    public long PersonId { get; set; }
    public int HospitalId { get; set; }
    public int TreatmentId { get; set; }

    #endregion

    #region Relations

    public virtual Person Person { get; set; }
    public virtual Hospital Hospital { get; set; }
    public virtual Treatment Treatment { get; set; }
    public virtual ICollection<Health> Healths { get; set; }
    public virtual ICollection<TeamMember> TeamMembers { get; set; }

    #endregion
}