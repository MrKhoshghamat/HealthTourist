using System.Collections;
using HealthTourist.Domain.AboutUsPage;
using HealthTourist.Domain.Account;
using HealthTourist.Domain.Department;
using HealthTourist.Domain.Persistence;

namespace HealthTourist.Domain.Common;

public class Attachment : BaseEntity<Guid>
{
    #region Properties

    /// <summary>
    /// Data Content
    /// </summary>
    public byte[] Data { get; set; }
        
    /// <summary>
    /// Type
    /// </summary>
    public string FileExtension { get; set; }

    #endregion

    #region Relations

    /// <summary>
    /// Person Attachments
    /// </summary>
    public virtual ICollection<PersonAttachment> PersonAttachments { get; set; }
    
    /// <summary>
    /// About Us Attachment
    /// </summary>
    public virtual ICollection<AboutUsAttachment> AboutUsAttachments { get; set; }

    /// <summary>
    /// Patient Attachments
    /// </summary>
    public virtual ICollection<PatientAttachment> PatientAttachments { get; set; }

    #endregion
}