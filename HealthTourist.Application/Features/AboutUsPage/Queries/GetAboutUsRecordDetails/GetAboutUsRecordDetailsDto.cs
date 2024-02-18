namespace HealthTourist.Application.Features.AboutUsPage.Queries.GetAboutUsRecordDetails;

public abstract class GetAboutUsRecordDetailsDto
{
    /// <summary>
    /// Title
    /// </summary>
    public string Title { get; set; }
    
    /// <summary>
    /// Description
    /// </summary>
    public string Description { get; set; }
}