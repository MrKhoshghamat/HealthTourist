using HealthTourist.Api.Models.Home.Sub;

namespace HealthTourist.Api.Models.Home.Main;

public class GetHomeDto
{
    public List<HomeFaqTypesDto> FaqTypes { get; set; }
    public List<HomeTreatmentTypesDto> TreatmentTypes { get; set; }
    public List<HomeDoctorsDto> Doctors { get; set; }
    public List<HomeHospitalsDto> Hospitals { get; set; }
    public List<HomeHotelsDto> Hotels { get; set; }
}