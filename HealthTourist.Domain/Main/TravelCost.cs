namespace HealthTourist.Domain.Main;

public class TravelCost : BaseEntity<int>
{
    #region Properties

    public Guid TravelId { get; set; }
    public int CostDetailsId { get; set; }
    public string Cost { get; set; }

    #endregion

    #region Relations

    public virtual Travel Travel { get; set; }
    public virtual CostDetails CostDetails { get; set; }

    #endregion
}