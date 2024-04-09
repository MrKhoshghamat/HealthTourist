namespace HealthTourist.Application.Features.Main.Doctor.Queries.GetDoctorAttachmentByDoctorId;

public class GetDoctorAttachmentByDoctorIdDto
{
    public long DoctorId { get; set; }
    public Guid AttachmentId { get; set; }
    public byte[] Content { get; set; }
}