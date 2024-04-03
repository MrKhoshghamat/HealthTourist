using HealthTourist.Domain.Interface;

namespace HealthTourist.Domain.Main;

public class FaqType : BaseEntity<int>
{
    #region Properties

    public string Name { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int Priority { get; set; }

    #endregion

    #region Relations

    public virtual ICollection<Faq> Faqs { get; set; }
    public virtual ICollection<FaqTypeAttachment> FaqTypeAttachments { get; set; }

    #endregion
}