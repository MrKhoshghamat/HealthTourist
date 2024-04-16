using HealthTourist.Common.Enumerations.Common;
using Microsoft.AspNetCore.Mvc;

namespace HealthTourist.Api.Models.Home.Sub;

public class HomeDoctorsDto
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Treatment { get; set; }
    public List<SocialMediaEnum> SocialMedias { get; set; }
    public List<string> SocialMediaLinks { get; set; }
    public FileContentResult Picture { get; set; }
}