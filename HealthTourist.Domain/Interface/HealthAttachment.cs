using HealthTourist.Domain.Common;
using HealthTourist.Domain.Main;

namespace HealthTourist.Domain.Interface;

public class HealthAttachment
{
    #region Properties

    public Guid HealthId { get; set; }
    public Guid AttachmentId { get; set; }

    #endregion

    #region Relations

    public virtual Health Health { get; set; }
    public virtual Attachment Attachment { get; set; }

    #endregion
}