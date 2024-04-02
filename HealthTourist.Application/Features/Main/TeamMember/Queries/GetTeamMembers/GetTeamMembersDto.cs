using HealthTourist.Domain.Account;
using HealthTourist.Domain.Main;

namespace HealthTourist.Application.Features.Main.TeamMember.Queries.GetTeamMembers;

public class GetTeamMembersDto
{
    #region Properties

    public long PersonId { get; set; }
    public long DoctorId { get; set; }
    public int TreatmentId { get; set; }

    #endregion

    #region Relations

    public virtual Person Person { get; set; }
    public virtual Domain.Main.Doctor Doctor { get; set; }
    public virtual Treatment Treatment { get; set; }

    #endregion
}