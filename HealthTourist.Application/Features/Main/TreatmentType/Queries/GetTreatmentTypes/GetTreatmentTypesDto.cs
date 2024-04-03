using HealthTourist.Domain.Interface;
using HealthTourist.Domain.Main;

namespace HealthTourist.Application.Features.Main.TreatmentType.Queries.GetTreatmentTypes;

public class GetTreatmentTypesDto
{
    #region Properties

    public string Name { get; set; }
    public string Title { get; set; }

    #endregion

    #region Relations

    public virtual ICollection<Domain.Main.Treatment> Treatments { get; set; }
    public virtual ICollection<TreatmentTypeAttachment> TreatmentTypeAttachments { get; set; }

    #endregion
}