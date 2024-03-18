using HealthTourist.Domain.Persistence;

namespace HealthTourist.Domain.Common;

public class Location : BaseEntity<Guid>
{
    #region Properties

    public string Name { get; set; }
    public string Title { get; set; }
    public string Latitude { get; set; }
    public string Longitude { get; set; }

    #endregion

    #region Relations

    /// <summary>
    /// Interface table between Office and Location
    /// </summary>
    public virtual ICollection<OfficeLocation> OfficeLocations { get; set; }

    #endregion
}