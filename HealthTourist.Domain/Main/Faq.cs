namespace HealthTourist.Domain.Main;

public class Faq : BaseEntity<int>
{
    #region Properties

    public int FaqTypeId { get; set; }
    public string Name { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int Priority { get; set; }
    public bool IsFirstPage { get; set; }

    #endregion

    #region Relations

    public virtual FaqType FaqType { get; set; }

    #endregion
}