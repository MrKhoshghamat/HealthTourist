namespace HealthTourist.Application.Features.Main.TeamMember.Queries.GetTeamMemberAttachmentByTeamMemberId;

public class GetTeamMemberAttachmentByTeamMemberIdDto
{
    public long TeamMemberId { get; set; }
    public Guid AttachmentId { get; set; }
    public byte[] Content { get; set; }
}