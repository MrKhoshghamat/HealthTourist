namespace HealthTourist.Application.Features.AboutUsPage.Queries.GetAboutUsRecords;

public abstract class GetAboutUsRecordsDto
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