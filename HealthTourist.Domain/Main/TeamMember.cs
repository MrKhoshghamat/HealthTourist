using HealthTourist.Domain.Account;
using HealthTourist.Domain.Interface;

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
    public ICollection<TeamMemberSocialMedia> TeamMemberSocialMediae { get; set; }
    public virtual ICollection<TeamMemberAttachment> TeamMemberAttachments { get; set; }

    #endregion
}