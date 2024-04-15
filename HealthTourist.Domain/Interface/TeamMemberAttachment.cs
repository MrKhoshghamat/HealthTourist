using HealthTourist.Domain.Common;
using HealthTourist.Domain.Main;

namespace HealthTourist.Domain.Interface;

public class TeamMemberAttachment
{
    #region Properties

    public long TeamMemberId { get; set; }
    public Guid AttachmentId { get; set; }

    #endregion

    #region Relations

    public virtual TeamMember TeamMember { get; set; }
    public virtual Attachment Attachment { get; set; }

    #endregion
}