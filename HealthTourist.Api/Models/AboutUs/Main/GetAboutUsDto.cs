using HealthTourist.Api.Models.AboutUs.Sub;

namespace HealthTourist.Api.Models.AboutUs.Main;

public class GetAboutUsDto
{
    public List<AboutUsTeamMemberDto> TeamMembers { get; set; }
    public List<AboutUsOfficeDto> Offices { get; set; }
}