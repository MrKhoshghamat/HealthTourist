namespace HealthTourist.Domain.Common;

public class State : BaseEntity<int>
{
    #region Properties

    public int CountryId { get; set; }
    public string Name { get; set; }
    public string Title { get; set; }

    #endregion

    #region Relations

    public virtual Country Country { get; set; }
    public virtual ICollection<City> Cities { get; set; }

    #endregion
}