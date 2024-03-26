namespace HealthTourist.Domain.Main;

public class InvoiceCost : BaseEntity<int>
{
    #region Properties

    public int InvoiceId { get; set; }
    public int CostDetailsId { get; set; }
    public string Cost { get; set; }

    #endregion

    #region Relations

    public virtual Invoice Invoice { get; set; }
    public virtual CostDetails CostDetails { get; set; }

    #endregion
}