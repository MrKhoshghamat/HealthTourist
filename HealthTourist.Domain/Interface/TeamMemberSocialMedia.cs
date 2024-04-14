using HealthTourist.Common.Enumerations.Common;
using HealthTourist.Domain.Main;

namespace HealthTourist.Domain.Interface;

public class TeamMemberSocialMedia
{
    #region Properties

    public long TeamMemberId { get; set; }
    public SocialMediaEnum SocialMedia { get; set; }
    public string Link { get; set; }

    #endregion

    #region Relations

    public virtual TeamMember TeamMember { get; set; }

    #endregion
}