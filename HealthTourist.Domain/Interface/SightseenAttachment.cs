using HealthTourist.Domain.Common;
using HealthTourist.Domain.Main;

namespace HealthTourist.Domain.Interface;

public class SightseenAttachment
{
    #region Properties

    public int SightseenId { get; set; }
    public int AttachmentId { get; set; }

    #endregion

    #region Relations

    public virtual Sightseen Sightseen { get; set; }
    public virtual Attachment Attachment { get; set; }

    #endregion
}