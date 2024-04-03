using HealthTourist.Domain.Common;
using HealthTourist.Domain.Main;

namespace HealthTourist.Domain.Interface;

public class TreatmentTypeAttachment
{
    #region Properties

    public int TreatmentTypeId { get; set; }
    public Guid AttachmentId { get; set; }

    #endregion

    #region Relations

    public virtual TreatmentType TreatmentType { get; set; }
    public virtual Attachment Attachment { get; set; }

    #endregion
}