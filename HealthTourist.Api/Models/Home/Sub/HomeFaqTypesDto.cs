using Microsoft.AspNetCore.Mvc;

namespace HealthTourist.Api.Models.Home.Sub;

public class HomeFaqTypesDto
{
    public string Name { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int Priority { get; set; }
    public FileContentResult Icon { get; set; }
    public FileContentResult SelectedIcon { get; set; }
}