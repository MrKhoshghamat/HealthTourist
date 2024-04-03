using HealthTourist.Domain.Main;

namespace HealthTourist.Domain.Common;

public class Country : BaseEntity<int>
{
    #region Properties

    public string Name { get; set; }
    public string Title { get; set; }
    public string Code { get; set; }

    #endregion

    #region Relations

    public virtual ICollection<State> States { get; set; }
    public virtual ICollection<Office> Offices { get; set; }

    #endregion
}