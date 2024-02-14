using HealthTourist.Domain.Common;

namespace HealthTourist.Domain.AboutUsPage;

public class AboutUsAttachment
{
    #region Properties

    /// <summary>
    /// About Us Id
    /// </summary>
    public int AboutUsId { get; set; }
    
    /// <summary>
    /// Attachment Id
    /// </summary>
    public int AttachmentId { get; set; }

    #endregion

    #region Relations

    /// <summary>
    /// About Us 
    /// </summary>
    public virtual AboutUs AboutUs { get; set; }
    
    /// <summary>
    /// Attachment
    /// </summary>
    public virtual Attachment Attachment { get; set; }

    #endregion
}