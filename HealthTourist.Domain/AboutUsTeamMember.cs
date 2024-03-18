namespace HealthTourist.Domain;

public class AboutUsTeamMember
{
    #region Properties

    /// <summary>
    /// About Us Id
    /// </summary>
    public int AboutUsId { get; set; }

    /// <summary>
    /// Team Member Id
    /// </summary>
    public int TeamMemberId { get; set; }

    #endregion

    #region Relations

    /// <summary>
    /// About Us
    /// </summary>
    public virtual AboutUs AboutUs { get; set; }
    
    /// <summary>
    /// Team Member
    /// </summary>
    public virtual TeamMember TeamMember { get; set; }

    #endregion
}