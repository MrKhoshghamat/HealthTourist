using HealthTourist.Common.Enumerations.Common;

namespace HealthTourist.Domain.Common;

public class Attachment : BaseEntity<Guid>
{
    #region Properties

    public byte[] Content { get; set; }
    public string Name { get; set; }
    public FileExtensionEnum Extension { get; set; }

    #endregion

    #region Relations

    

    #endregion
}