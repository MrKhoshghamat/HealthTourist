using MediatR;

namespace HealthTourist.Application.Features.AboutUsAttachments.Commands.CreateAboutUsAttachment;

public abstract class CreateAboutUsAttachmentCommand : IRequest<Unit> 
{
    /// <summary>
    /// About Us Id
    /// </summary>
    public int AboutUsId { get; set; }
    
    /// <summary>
    /// Attachment Id
    /// </summary>
    public Guid AttachmentId { get; set; }
}