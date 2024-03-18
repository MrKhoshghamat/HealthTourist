namespace HealthTourist.Domain;

public class AboutUsOffice
{
    #region Properties

    /// <summary>
    /// About Us Id
    /// </summary>
    public int AboutUsId { get; set; }
    
    /// <summary>
    /// Office Id 
    /// </summary>
    public int OfficeId { get; set; }

    #endregion

    #region Relations

    /// <summary>
    /// About Us
    /// </summary>
    public virtual AboutUs AboutUs { get; set; }
    
    /// <summary>
    /// Office
    /// </summary>
    public virtual Office Office { get; set; }

    #endregion
}