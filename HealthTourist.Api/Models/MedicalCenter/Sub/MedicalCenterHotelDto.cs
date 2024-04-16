using Microsoft.AspNetCore.Mvc;

namespace HealthTourist.Api.Models.MedicalCenter.Sub;

public class MedicalCenterHotelDto
{
    public string Name { get; set; }
    public string Title { get; set; }
    public FileContentResult Picture { get; set; }
}