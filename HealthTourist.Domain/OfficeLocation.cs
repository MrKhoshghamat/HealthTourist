using HealthTourist.Domain.Common;

namespace HealthTourist.Domain;

public class OfficeLocation
{
    #region Properties

    /// <summary>
    /// Office Name
    /// </summary>
    public string OfficeName { get; set; }
    
    /// <summary>
    /// Office Id
    /// </summary>
    public int OfficeId { get; set; }
    
    /// <summary>
    /// Location Name
    /// </summary>
    public string LocationName { get; set; }
    
    /// <summary>
    /// Location Id
    /// </summary>
    public Guid LocationId { get; set; }

    #endregion

    #region Relations

    /// <summary>
    /// Office
    /// </summary>
    public Office Office { get; set; }
    
    /// <summary>
    /// Location
    /// </summary>
    public Location Location { get; set; }

    #endregion
}