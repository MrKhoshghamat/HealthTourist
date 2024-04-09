using HealthTourist.Application.Features.Main.Hospital.Queries.GetHospitalAttachmentByHospitalId;
using HealthTourist.Application.Features.Main.Hospital.Queries.GetHospitalTagsByHospitalId;

namespace HealthTourist.Api.Models.Home.Sub;

public class HomeHospitalsDto
{
    public string Name { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public List<GetHospitalTagsByHospitalIdDto> Tags { get; set; }
    public List<GetHospitalAttachmentByHospitalIdDto> Pictures { get; set; }
}