using HealthTourist.Domain;

namespace HealthTourist.Application.Features.AboutUsPage.Queries.GetAboutUsRecords;

public class GetAboutUsRecordsDto
{
    /// <summary>
    /// Title
    /// </summary>
    public string Title { get; set; }
    
    /// <summary>
    /// Description
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Team Members
    /// </summary>
    public List<TeamMember> TeamMembers { get; set; }

    /// <summary>
    /// Offices
    /// </summary>
    public List<Office> Offices { get; set; }
}