using HealthTourist.Common.Enumerations.Common;

namespace HealthTourist.Api.Models.Department.Sub;

public class DepartmentDoctorDto
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Treatment { get; set; }
    public byte[] Picture { get; set; }
    public List<SocialMediaEnum> SocialMediae { get; set; }
    public List<string> SocialMediaLinks { get; set; }
}