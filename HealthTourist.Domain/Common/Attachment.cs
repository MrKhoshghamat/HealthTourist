using HealthTourist.Domain.Account;
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

    #endregion
}