namespace HealthTourist.Application.Features.Attachments.Queries.GetAttachmentDetails;

public class GetAttachmentDetailsDto
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