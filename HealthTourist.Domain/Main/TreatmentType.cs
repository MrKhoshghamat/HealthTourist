namespace HealthTourist.Domain.Main;

public class TreatmentType : BaseEntity<int>
{
    #region Properties

    public string Name { get; set; }
    public string Title { get; set; }

    #endregion

    #region Relations

    public virtual ICollection<Treatment> Treatments { get; set; }

    #endregion
}