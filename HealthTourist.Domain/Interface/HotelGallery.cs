using HealthTourist.Domain.Common;
using HealthTourist.Domain.Main;

namespace HealthTourist.Domain.Interface;

public class HotelGallery
{
    #region Properties

    public int HotelId { get; set; }
    public Guid AttachmentId { get; set; }

    #endregion

    #region Relations

    public virtual Hotel Hotel { get; set; }
    public virtual Attachment Attachment { get; set; }

    #endregion
}