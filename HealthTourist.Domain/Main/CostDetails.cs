namespace HealthTourist.Domain.Main;

public class CostDetails : BaseEntity<int>
{
    #region Properties

    public string Name { get; set; }
    public string Title { get; set; }

    #endregion

    #region Relations

    public virtual ICollection<HealthCost> HealthCosts { get; set; }
    public virtual ICollection<InvoiceCost> InvoiceCosts { get; set; }
    public virtual ICollection<TravelCost> TravelCosts { get; set; }

    #endregion
}