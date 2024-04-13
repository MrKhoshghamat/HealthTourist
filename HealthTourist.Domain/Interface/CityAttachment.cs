using HealthTourist.Domain.Common;

namespace HealthTourist.Domain.Interface;

public class CityAttachment
{
    #region Properties

    public int CityId { get; set; }
    public Guid AttachmentId { get; set; }

    #endregion

    #region Relations

    public virtual City City { get; set; }
    public virtual Attachment Attachment { get; set; }

    #endregion
}