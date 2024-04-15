namespace HealthTourist.Api.Models.Faq.Sub;

public class FaqFaqDto
{
    public int FaqTypeId { get; set; }
    public string Name { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int Priority { get; set; }
    public bool IsFirstPage { get; set; }
}