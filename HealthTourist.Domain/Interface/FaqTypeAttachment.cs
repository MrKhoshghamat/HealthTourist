using HealthTourist.Domain.Common;
using HealthTourist.Domain.Main;

namespace HealthTourist.Domain.Interface;

public class FaqTypeAttachment
{
    #region Properties

    public int FaqTypeId { get; set; }
    public Guid AttachmentId { get; set; }
    public bool IsSelected { get; set; }

    #endregion

    #region Relations

    public virtual FaqType FaqType { get; set; }
    public virtual Attachment Attachment { get; set; }

    #endregion
}