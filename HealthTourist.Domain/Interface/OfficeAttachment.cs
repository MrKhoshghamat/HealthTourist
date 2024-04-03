using HealthTourist.Domain.Common;
using HealthTourist.Domain.Main;

namespace HealthTourist.Domain.Interface;

public class OfficeAttachment
{
    #region Properties

    public int OfficeId { get; set; }
    public Guid AttachmentId { get; set; }

    #endregion

    #region Relations

    public virtual Office Office { get; set; }
    public virtual Attachment Attachment { get; set; }

    #endregion
}