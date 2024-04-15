namespace HealthTourist.Api.Models.Faq.Sub;

public class FaqFaqTypesDto
{
    public string Name { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int Priority { get; set; }
    public byte[] Icon { get; set; }
    public byte[] SelectedIcon { get; set; }
}