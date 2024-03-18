using HealthTourist.Common.Enumerations.AboutUs;
using HealthTourist.Domain.Account;
using HealthTourist.Domain.Persistence;

namespace HealthTourist.Domain;

public class TeamMember : BaseEntity<int>
{
    #region Properties

    /// <summary>
    /// Person Id
    /// </summary>
    public long PersonId { get; set; }

    /// <summary>
    /// Career Position and Side
    /// </summary>
    public CareerPositionEnum CareerPosition { get; set; }

    /// <summary>
    /// Career Position Prefix like Dr.
    /// </summary>
    public CareerPositionInShortEnum Prefix { get; set; }

    #endregion

    #region Relations

    /// <summary>
    /// Person
    /// </summary>
    public virtual Person Person { get; set; }

    /// <summary>
    /// Team Member State Relation
    /// </summary>
    public virtual ICollection<TeamMemberState> TeamMemberStates { get; set; }

    /// <summary>
    /// Team Member Social Medias Relation
    /// </summary>
    public virtual ICollection<TeamMemberSocialMedia> TeamMemberSocialMedias { get; set; }

    /// <summary>
    /// About Us Team Members
    /// </summary>
    public virtual ICollection<AboutUsTeamMember> AboutUsTeamMembers { get; set; }

    #endregion
}