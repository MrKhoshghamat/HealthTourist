using HealthTourist.Domain.Account;
using HealthTourist.Domain.Interface;
using MediatR;

namespace HealthTourist.Application.Features.Main.TeamMember.Commands.DeleteTeamMember;

public class DeleteTeamMemberCommand : IRequest<Unit>
{
    #region Properties

    public long PersonId { get; set; }
    public long DoctorId { get; set; }
    public int TreatmentId { get; set; }

    #endregion

    #region Relations

    public virtual Person Person { get; set; }
    public virtual Domain.Main.Doctor Doctor { get; set; }
    public virtual Domain.Main.Treatment Treatment { get; set; }
    public ICollection<TeamMemberSocialMedia> TeamMemberSocialMediae { get; set; }
    public virtual ICollection<TeamMemberAttachment> TeamMemberAttachments { get; set; }

    #endregion
}