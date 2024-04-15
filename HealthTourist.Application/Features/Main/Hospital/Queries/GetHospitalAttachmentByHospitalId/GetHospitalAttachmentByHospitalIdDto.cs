namespace HealthTourist.Application.Features.Main.Hospital.Queries.GetHospitalAttachmentByHospitalId;

public class GetHospitalAttachmentByHospitalIdDto
{
    public int HospitalId { get; set; }
    public List<byte[]> Contents { get; set; }
}