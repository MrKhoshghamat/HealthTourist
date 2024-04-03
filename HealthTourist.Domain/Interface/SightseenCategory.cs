using HealthTourist.Domain.Main;

namespace HealthTourist.Domain.Interface;

public class SightseenCategory
{
    #region Properties

    public int SightseenId { get; set; }
    public int CategoryId { get; set; }

    #endregion

    #region Relations

    public virtual Sightseen Sightseen { get; set; }
    public virtual Category Category { get; set; }

    #endregion
}