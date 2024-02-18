using MediatR;

namespace HealthTourist.Application.Features.Attachments.Commands.UpdateAttachment;

public class UpdateAttachmentCommand : IRequest<Unit>
{
    /// <summary>
    /// Id
    /// </summary>
    public Guid Id { get; set; }
    
    /// <summary>
    /// Data Content
    /// </summary>
    public byte[] Data { get; set; }
        
    /// <summary>
    /// Type
    /// </summary>
    public string FileExtension { get; set; }
}