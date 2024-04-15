using HealthTourist.Api.Models.Faq.Sub;

namespace HealthTourist.Api.Models.Faq.Main;

public class GetFaqDto
{
    public List<FaqFaqTypesDto> FaqTypes { get; set; }
    public FaqFaqDto Faq { get; set; }
}