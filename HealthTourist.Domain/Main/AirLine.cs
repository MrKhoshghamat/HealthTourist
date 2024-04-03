namespace HealthTourist.Domain.Main;

public class AirLine : BaseEntity<int>
{
    #region Properties

    public string Name { get; set; }
    public string Title { get; set; }

    #endregion

    #region Relations

    public virtual ICollection<Travel> Travels { get; set; }

    #endregion
}