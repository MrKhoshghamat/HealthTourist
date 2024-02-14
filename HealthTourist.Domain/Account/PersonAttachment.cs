using HealthTourist.Common.Enumerations.Common;
using HealthTourist.Domain.Common;

namespace HealthTourist.Domain.Account;

public class PersonAttachment
{
    #region Properties

    /// <summary>
    /// Person Id
    /// </summary>
    public int PersonId { get; set; }
    
    /// <summary>
    /// Attachment Id
    /// </summary>
    public long AttachmentId { get; set; }

    /// <summary>
    /// File Type Extension
    /// </summary>
    public FileExtensionEnum ExtensionType { get; set; }

    #endregion

    #region Relations

    /// <summary>
    /// Person
    /// </summary>
    public Person Person { get; set; }
    
    /// <summary>
    /// Attachment
    /// </summary>
    public Attachment Attachment { get; set; }

    #endregion
}