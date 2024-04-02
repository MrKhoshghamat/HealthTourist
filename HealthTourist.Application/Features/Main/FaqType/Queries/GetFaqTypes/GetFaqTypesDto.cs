namespace HealthTourist.Application.Features.Main.FaqType.Queries.GetFaqTypes;

public class GetFaqTypesDto
{
    #region Properties

    public string Name { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int Priority { get; set; }

    #endregion

    #region Relations

    public virtual ICollection<Domain.Main.Faq> Faqs { get; set; }

    #endregion
}