using HealthTourist.Domain.Common;
using HealthTourist.Domain.Main;

namespace HealthTourist.Domain.Interface;

public class HospitalAttachment
{
    #region Properties

    public int HospitalId { get; set; }
    public Guid AttachmentId { get; set; }

    #endregion

    #region Relations

    public virtual Hospital Hospital { get; set; }
    public virtual Attachment Attachment { get; set; }

    #endregion
}