using MediatR;

namespace HealthTourist.Application.Features.AboutUsAttachments.Commands.DeleteAboutUsAttachment;

public abstract class DeleteAboutUsAttachmentCommand : IRequest<Unit>
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