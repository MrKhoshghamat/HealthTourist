namespace HealthTourist.Application.Features.Main.TreatmentType.Queries.GetTreatmentTypeIconByTreatmentTypeId;

public class GetTreatmentTypeIconByTreatmentTypeIdDto
{
    public int TreatmentTypeId { get; set; }
    public Guid AttachmentId { get; set; }
    public byte[] Content { get; set; }
}