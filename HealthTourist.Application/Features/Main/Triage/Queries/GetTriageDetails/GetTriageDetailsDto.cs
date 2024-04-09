using HealthTourist.Domain.Interface;

namespace HealthTourist.Application.Features.Main.Triage.Queries.GetTriageDetails;

public class GetTriageDetailsDto
{
    #region Properties

    public Guid TriageNo { get; set; }
    public long PatientId { get; set; }
    public int TreatmentId { get; set; }
    public string Description { get; set; }

    #endregion

    #region Relations

    public virtual Domain.Main.Patient Patient { get; set; }
    public virtual Domain.Main.Treatment Treatment { get; set; }
    public virtual ICollection<TriageAttachment> TriageAttachments { get; set; }

    #endregion
}