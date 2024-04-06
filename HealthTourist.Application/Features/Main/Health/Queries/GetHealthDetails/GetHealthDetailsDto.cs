using HealthTourist.Domain.Interface;

namespace HealthTourist.Application.Features.Main.Health.Queries.GetHealthDetails;

public class GetHealthDetailsDto
{
    #region Properties

    public Guid TriageNo { get; set; }
    public int HospitalId { get; set; }
    public long DoctorId { get; set; }
    public string Cost { get; set; }

    #endregion

    #region Relations

    public virtual Domain.Main.Hospital Hospital { get; set; }
    public virtual Domain.Main.Doctor Doctor { get; set; }
    public virtual ICollection<Domain.Main.HealthCost> HealthCosts { get; set; }
    public virtual ICollection<Domain.Main.Invoice> Invoices { get; set; }
    public virtual ICollection<HealthAttachment> HealthAttachments { get; set; }

    #endregion
}