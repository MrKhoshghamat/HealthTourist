using Microsoft.AspNetCore.Mvc;

namespace HealthTourist.Api.Models.Department.Sub;

public class DepartmentDoctorTeamMembersDto
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Treatment { get; set; }
    public FileContentResult Picture { get; set; }
}