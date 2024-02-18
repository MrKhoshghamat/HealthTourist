namespace HealthTourist.Application.Features.Attachments.Queries.GetAttachments;

public abstract class GetAttachmentsDto
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