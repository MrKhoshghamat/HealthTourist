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

    #endregion

    #region Releations

    /// <summary>
    /// About Us Attachments
    /// </summary>
    public virtual ICollection<AboutUsAttachment> AboutUsAttachments { get; set; }
    
    /// <summary>
    /// About Us Offices
    /// </summary>
    public virtual ICollection<AboutUsOffice> AboutUsOffices { get; set; }

    /// <summary>
    /// About Us Team Members
    /// </summary>
    public virtual ICollection<AboutUsTeamMember> AboutUsTeamMembers { get; set; }

    #endregion
}