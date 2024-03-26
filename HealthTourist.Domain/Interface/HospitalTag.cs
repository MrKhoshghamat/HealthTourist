using HealthTourist.Domain.Main;

namespace HealthTourist.Domain.Interface;

public class HospitalTag
{
    #region Properties

    public int HospitalId { get; set; }
    public int TagId { get; set; }

    #endregion

    #region Relations

    public virtual Hospital Hospital { get; set; }
    public virtual Tag Tag { get; set; }

    #endregion
}