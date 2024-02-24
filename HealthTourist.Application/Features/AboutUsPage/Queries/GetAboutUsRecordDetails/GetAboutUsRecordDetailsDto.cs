namespace HealthTourist.Application.Features.AboutUsPage.Queries.GetAboutUsRecordDetails;

public class GetAboutUsRecordDetailsDto
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
    /// Team Member Id
    /// </summary>
    public int TeamMemberId { get; set; }

    /// <summary>
    /// Office Id
    /// </summary>
    public int OfficeId { get; set; }
}