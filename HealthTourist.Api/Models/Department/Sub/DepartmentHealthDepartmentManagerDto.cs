namespace HealthTourist.Api.Models.Department.Sub;

public class DepartmentHealthDepartmentManagerDto
{
    public List<DepartmentDoctorDto> Doctors { get; set; }
    public List<DepartmentDoctorTeamMembersDto> TeamMembers { get; set; }
}