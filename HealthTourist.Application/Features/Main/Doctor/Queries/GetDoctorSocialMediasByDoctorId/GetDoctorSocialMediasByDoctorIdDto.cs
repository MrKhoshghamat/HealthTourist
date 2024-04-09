using HealthTourist.Common.Enumerations.Common;

namespace HealthTourist.Application.Features.Main.Doctor.Queries.GetDoctorSocialMediasByDoctorId;

public class GetDoctorSocialMediasByDoctorIdDto
{
    public long DoctorId { get; set; }
    public List<SocialMediaEnum> SocialMediae { get; set; }
    public List<string> Links { get; set; }
}