using HealthTourist.Domain.Common;
using HealthTourist.Domain.Main;

namespace HealthTourist.Domain.Interface;

public class TravelAttachment
{
    #region Properties

    public Guid TravelId { get; set; }
    public Guid AttachmentId { get; set; }

    #endregion

    #region Relations

    public virtual Travel Travel { get; set; }
    public virtual Attachment Attachment { get; set; }

    #endregion
}