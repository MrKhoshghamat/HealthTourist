using HealthTourist.Domain.Main;

namespace HealthTourist.Application.Features.Main.Faq.Queries.GetFaqDetails;

public class GetFaqDetailsDto
{
    public int FaqTypeId { get; set; }
    public string Name { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int Priority { get; set; }
    public bool IsFirstPage { get; set; }

    public virtual Domain.Main.FaqType FaqType { get; set; }
}