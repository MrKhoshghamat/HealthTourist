using HealthTourist.Application.Features.Main.Hospital.Queries.GetHospitalAttachmentByHospitalId;
using HealthTourist.Application.Features.Main.Hospital.Queries.GetHospitalTagsByHospitalId;
using Microsoft.AspNetCore.Mvc;

namespace HealthTourist.Api.Models.Home.Sub;

public class HomeHospitalsDto
{
    public string Name { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public List<string> Tags { get; set; }
    public List<FileContentResult> Pictures { get; set; }
}