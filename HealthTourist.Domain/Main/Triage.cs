using HealthTourist.Domain.Interface;

namespace HealthTourist.Domain.Main;

public class Triage : BaseEntity<Guid>
{
    #region Properties

    public Guid TriageNo { get; set; }
    public long PatientId { get; set; }
    public int TreatmentId { get; set; }
    public string Description { get; set; }

    #endregion

    #region Relations

    public virtual Patient Patient { get; set; }
    public virtual Treatment Treatment { get; set; }
    public virtual ICollection<TriageAttachment> TriageAttachments { get; set; }

    #endregion
}