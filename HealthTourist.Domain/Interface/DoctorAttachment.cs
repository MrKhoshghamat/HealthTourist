using HealthTourist.Domain.Common;
using HealthTourist.Domain.Main;

namespace HealthTourist.Domain.Interface;

public class DoctorAttachment
{
    #region Properties

    public long DoctorId { get; set; }
    public Guid AttachmentId { get; set; }

    #endregion

    #region Relations

    public virtual Doctor Doctor { get; set; }
    public virtual Attachment Attachment { get; set; }

    #endregion
}