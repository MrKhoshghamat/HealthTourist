namespace HealthTourist.Application.Features.Main.FaqType.Queries.GetFaqTypeIconByFaqTypeId;

public class GetFaqTypeIconByFaqTypeIdDto
{
    public int FaqTypeId { get; set; }
    public Guid AttachmentId { get; set; }
    public byte[] Content { get; set; }
    public bool IsSelected { get; set; }
}