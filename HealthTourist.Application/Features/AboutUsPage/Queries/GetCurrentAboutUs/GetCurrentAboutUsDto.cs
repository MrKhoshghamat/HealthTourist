using HealthTourist.Domain.AboutUsPage;
using HealthTourist.Domain.Common;

namespace HealthTourist.Application.Features.AboutUsPage.Queries.GetCurrentAboutUs;

public class GetCurrentAboutUsDto
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
    /// List of Attachments
    /// </summary>
    public List<Attachment> Attachments { get; set; }
    
    /// <summary>
    /// List of Team Members
    /// </summary>
    public List<TeamMember> TeamMembers { get; set; }
    
    /// <summary>
    /// List of Offices
    /// </summary>
    public List<Office> Offices { get; set; }
}