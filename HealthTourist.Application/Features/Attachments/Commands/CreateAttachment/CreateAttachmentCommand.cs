using MediatR;

namespace HealthTourist.Application.Features.Attachments.Commands.CreateAttachment;

public class CreateAttachmentCommand : IRequest<Guid>
{
    /// <summary>
    /// Data Content
    /// </summary>
    public byte[] Data { get; set; }
        
    /// <summary>
    /// Type
    /// </summary>
    public string FileExtension { get; set; }
}