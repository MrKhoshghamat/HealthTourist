namespace HealthTourist.Domain.Main;

public class Travel : BaseEntity<Guid>
{
    #region Properties

    public Guid TriageNo { get; set; }
    public long PatientId { get; set; }
    public int HotelId { get; set; }
    public int AirLineId { get; set; }
    public string Description { get; set; }
    public string Cost { get; set; }

    #endregion

    #region Relations

    public virtual Patient Patient { get; set; }
    public virtual Hotel Hotel { get; set; }
    public virtual AirLine AirLine { get; set; }
    public virtual ICollection<Invoice> Invoices { get; set; }
    public virtual ICollection<TravelCost> TravelCosts { get; set; }

    #endregion
}