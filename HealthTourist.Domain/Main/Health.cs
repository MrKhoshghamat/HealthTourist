using HealthTourist.Domain.Interface;

namespace HealthTourist.Domain.Main;

public class Health : BaseEntity<Guid>
{
    #region Properties

    public Guid TriageNo { get; set; }
    public int HospitalId { get; set; }
    public int DoctorId { get; set; }
    public string Cost { get; set; }

    #endregion

    #region Relations

    public virtual Hospital Hospital { get; set; }
    public virtual Doctor Doctor { get; set; }
    public virtual ICollection<HealthCost> HealthCosts { get; set; }
    public virtual ICollection<Invoice> Invoices { get; set; }
    public virtual ICollection<HealthAttachment> HealthAttachments { get; set; }

    #endregion
}