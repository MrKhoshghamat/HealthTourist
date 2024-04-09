namespace HealthTourist.Application.Features.Main.Hospital.Queries.GetHospitalTagsByHospitalId;

public class GetHospitalTagsByHospitalIdDto
{
    public int HospitalId { get; set; }
    public int TagId { get; set; }
    public string Title { get; set; }
}