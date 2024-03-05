
using HealthTourist.Domain.Common;

namespace HealthTourist.Domain.Department;

public class PatientAttachment
{
    #region Properties

    public long PatientId { get; set; }
    public Guid AttachmentId { get; set; }

    #endregion

    #region Relations

    public Patient Patient { get; set; }
    public Attachment Attachment { get; set; }

    #endregion
}