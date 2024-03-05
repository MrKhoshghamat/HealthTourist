using HealthTourist.Domain.Account;
using HealthTourist.Domain.Persistence;

namespace HealthTourist.Domain.Department;

public class Patient : BaseEntity<long>
{
    #region Properties

    /// <summary>
    /// Person Id
    /// </summary>
    public long PersonId { get; set; }

    /// <summary>
    /// Height
    /// </summary>
    public string Height { get; set; }
    
    /// <summary>
    /// Weight
    /// </summary>
    public string Weight { get; set; }
    
    /// <summary>
    /// Description in Triage Form
    /// </summary>
    public string Description { get; set; }

    #endregion

    #region Relations

    public virtual Person Person { get; set; }
    public virtual ICollection<PatientAttachment> PatientAttachments { get; set; }

    #endregion
}