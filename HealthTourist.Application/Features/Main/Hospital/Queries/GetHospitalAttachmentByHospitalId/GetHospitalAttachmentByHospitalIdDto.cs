namespace HealthTourist.Application.Features.Main.Hospital.Queries.GetHospitalAttachmentByHospitalId;

public class GetHospitalAttachmentByHospitalIdDto
{
    public int HospitalId { get; set; }
    public Guid AttachmentId { get; set; }
    public byte[] Content { get; set; }
}