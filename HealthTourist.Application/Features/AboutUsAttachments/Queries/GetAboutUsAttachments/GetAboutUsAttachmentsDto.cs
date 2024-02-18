using HealthTourist.Domain.AboutUsPage;
using HealthTourist.Domain.Common;

namespace HealthTourist.Application.Features.AboutUsAttachments.Queries.GetAboutUsAttachments;

public abstract class GetAboutUsAttachmentsDto
{
    /// <summary>
    /// About Us Id
    /// </summary>
    public int AboutUsId { get; set; }
    
    /// <summary>
    /// Attachment Id
    /// </summary>
    public int AttachmentId { get; set; }

    /// <summary>
    /// About Us 
    /// </summary>
    public virtual AboutUs AboutUs { get; set; }
    
    /// <summary>
    /// Attachment
    /// </summary>
    public virtual Attachment Attachment { get; set; }
}