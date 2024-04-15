using HealthTourist.Api.Models.MedicalCenter.Sub;

namespace HealthTourist.Api.Models.MedicalCenter.Main;

public class GetMedicalCenterDto
{
    public List<string> MedicalCentersNames { get; set; }
    public List<MedicalCenterHospitalDto> MedicalCenters { get; set; }
    public List<MedicalCenterHotelDto> Hotels { get; set; }
}