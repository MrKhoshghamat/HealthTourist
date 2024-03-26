using HealthTourist.Domain.Common;

namespace HealthTourist.Domain.Main;

public class Sightseen : BaseEntity<int>
{
    #region Properties

    public int CityId { get; set; }
    public string Name { get; set; }
    public string Title { get; set; }
    public long Lat { get; set; }
    public long Long { get; set; }

    #endregion

    #region Relations

    public virtual City City { get; set; }

    #endregion
}