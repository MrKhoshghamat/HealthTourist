namespace HealthTourist.Domain.Main;

public class Invoice : BaseEntity<long>
{
    #region Properties

    public Guid HealthId { get; set; }
    public Guid TravelId { get; set; }
    public string TotalPrice { get; set; }

    #endregion

    #region Relations

    public virtual Health Health { get; set; }
    public virtual Travel Travel { get; set; }
    public virtual ICollection<InvoiceCost> InvoiceCosts { get; set; }

    #endregion
}