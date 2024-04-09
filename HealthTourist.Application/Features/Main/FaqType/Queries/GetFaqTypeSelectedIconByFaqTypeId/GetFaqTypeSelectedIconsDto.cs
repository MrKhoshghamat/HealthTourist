namespace HealthTourist.Application.Features.Main.FaqType.Queries.GetFaqTypeSelectedIconByFaqTypeId;

public class GetFaqTypeSelectedIconByFaqTypeIdDto
{
    public int FaqTypeId { get; set; }
    public Guid AttachmentId { get; set; }
    public byte[] Content { get; set; }
    public bool IsSelected { get; set; }
}