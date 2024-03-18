using HealthTourist.Common.Enumerations.AboutUs;

namespace HealthTourist.Domain;

public class TeamMemberSocialMedia
{
    #region Properties

    /// <summary>
    /// Team Member Id
    /// </summary>
    public int TeamMemberId { get; set; }
    
    /// <summary>
    /// Social Media Title
    /// </summary>
    public SocialMediaEnum SocialMedia { get; set; }

    #endregion

    #region Relations

    /// <summary>
    /// Team Member
    /// </summary>
    public virtual TeamMember TeamMember { get; set; }

    #endregion
}