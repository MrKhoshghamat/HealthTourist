using Microsoft.AspNetCore.Mvc;

namespace HealthTourist.Api.Models.Home.Sub;

public class HomeHotelsDto
{
    public string Name { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public FileContentResult Picture { get; set; }
}