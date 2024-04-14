namespace HealthTourist.Application.Features.Main.TeamMember.Queries.GetTeamMemberSocialMediasByTeamMemberId;

public class GetTeamMemberSocialMediasByTeamMemberIdDto
{
    public long TeamMemberId { get; set; }
    public List<string> SocialMediae { get; set; }
}