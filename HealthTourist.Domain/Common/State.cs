using HealthTourist.Domain.Persistence;

namespace HealthTourist.Domain.Common;

public class State : BaseEntity<int>
{
    #region Properties

    /// <summary>
    /// Title of state
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// Parent Id
    /// </summary>
    public long? ParentId { get; set; }

    #endregion

    #region Relations

    /// <summary>
    /// State
    /// </summary>
    public State? Parent { get; set; }

    #endregion
}