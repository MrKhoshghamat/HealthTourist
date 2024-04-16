using Microsoft.AspNetCore.Mvc;

namespace HealthTourist.Api.Models.MedicalCenter.Sub;

public class MedicalCenterHospitalDto
{
    public string Name { get; set; }
    public string Title { get; set; }
    public string HospitalType { get; set; }
    public string Country { get; set; }
    public string Description { get; set; }
    public List<string> Tags { get; set; }
    public List<FileContentResult> Pictures { get; set; }
}