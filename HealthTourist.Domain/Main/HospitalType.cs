namespace HealthTourist.Domain.Main;

public class HospitalType : BaseEntity<int>
{
    #region Properties

    public string Name { get; set; }
    public string Title { get; set; }

    #endregion

    #region Relations

    public virtual ICollection<Hospital> Hospitals { get; set; }

    #endregion
}