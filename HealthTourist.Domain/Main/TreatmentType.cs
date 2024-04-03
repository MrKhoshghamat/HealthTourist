using HealthTourist.Domain.Interface;

namespace HealthTourist.Domain.Main;

public class TreatmentType : BaseEntity<int>
{
    #region Properties

    public string Name { get; set; }
    public string Title { get; set; }

    #endregion

    #region Relations

    public virtual ICollection<Treatment> Treatments { get; set; }
    public virtual ICollection<TreatmentTypeAttachment> TreatmentTypeAttachments { get; set; }

    #endregion
}