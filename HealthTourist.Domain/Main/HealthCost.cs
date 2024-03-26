namespace HealthTourist.Domain.Main;

public class HealthCost : BaseEntity<int>
{
    #region Properties

    public Guid HealthId { get; set; }
    public int CostDetailsId { get; set; }
    public string Cost { get; set; }

    #endregion

    #region Relations

    public virtual Health Health { get; set; }
    public virtual CostDetails CostDetails { get; set; }

    #endregion
}