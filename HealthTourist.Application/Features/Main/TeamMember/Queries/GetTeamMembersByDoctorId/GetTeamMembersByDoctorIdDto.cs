namespace HealthTourist.Application.Features.Main.TeamMember.Queries.GetTeamMembersByDoctorId;

public class GetTeamMembersByDoctorIdDto
{
    public long Id { get; set; }
    public long DoctorId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Treatment { get; set; }
}