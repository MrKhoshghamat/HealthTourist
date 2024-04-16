using Microsoft.AspNetCore.Mvc;

namespace HealthTourist.Api.Models.Home.Sub;

public class HomeTreatmentTypesDto
{
    public string Name { get; set; }
    public string Title { get; set; }
    public FileContentResult Icon { get; set; }
}