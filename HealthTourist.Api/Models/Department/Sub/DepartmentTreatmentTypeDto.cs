using Microsoft.AspNetCore.Mvc;

namespace HealthTourist.Api.Models.Department.Sub;

public class DepartmentTreatmentTypeDto
{
    public string Name { get; set; }
    public string Title { get; set; }
    public FileContentResult Icon { get; set; }
}