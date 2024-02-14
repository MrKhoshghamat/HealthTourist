using HealthTourist.Domain.Common;

namespace HealthTourist.Domain.AboutUsPage;

public class TeamMemberState
{
    #region Properties

    /// <summary>
    /// Team Member Id
    /// </summary>
    public int TeamMemberId { get; set; }
    
    /// <summary>
    /// State Id
    /// </summary>
    public int StateId { get; set; }

    #endregion

    #region Relations

    /// <summary>
    /// Team Member
    /// </summary>
    public virtual TeamMember TeamMember { get; set; }
    
    /// <summary>
    /// State
    /// </summary>
    public virtual State State { get; set; }

    #endregion
}