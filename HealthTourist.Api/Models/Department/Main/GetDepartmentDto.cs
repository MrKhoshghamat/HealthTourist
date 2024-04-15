using HealthTourist.Api.Models.Department.Sub;

namespace HealthTourist.Api.Models.Department.Main;

public class GetDepartmentDto
{
    public List<DepartmentTreatmentTypeDto> TreatmentTypes { get; set; }
    public DepartmentHealthDepartmentManagerDto HealthDepartmentManagers { get; set; }
    public DepartmentTriageFormBasicDataDto TriageFormBasicData { get; set; }
}