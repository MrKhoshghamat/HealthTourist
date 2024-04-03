using HealthTourist.Domain.Common;
using HealthTourist.Domain.Main;

namespace HealthTourist.Domain.Interface;

public class TriageAttachment
{
    #region Properties

    public Guid TriageId { get; set; }
    public Guid AttachmentId { get; set; }

    #endregion

    #region Relations

    public virtual Triage Triage { get; set; }
    public virtual Attachment Attachment { get; set; }

    #endregion
}