using HealthTourist.Domain.Persistence;

namespace HealthTourist.Domain.AboutUsPage;

public class AboutUs : BaseEntity<int>
{
    #region Properties

    /// <summary>
    /// Title
    /// </summary>
    public string Title { get; set; }
    
    /// <summary>
    /// Description
    /// </summary>
    public string Description { get; set; }
    
    /// <summary>
    /// List Of Team Members
    /// </summary>
    public List<TeamMember> TeamMembers { get; set; }
    
    /// <summary>
    /// List Of Offices
    /// </summary>
    public List<Office> Offices { get; set; }

    #endregion

    #region Releations

    /// <summary>
    /// About Us Attachments
    /// </summary>
    public virtual ICollection<AboutUsAttachment> AboutUsAttachments { get; set; }

    #endregion
}