namespace HealthTourist.Application.Features.Main.Hospital.Queries.GetHospitalTagsByHospitalId;

public class GetHospitalTagsByHospitalIdDto
{
    public int HospitalId { get; set; }
    public List<string> Tags { get; set; }
}