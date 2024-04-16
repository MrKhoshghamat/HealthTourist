using HealthTourist.Domain.Interface;
using MediatR;

namespace HealthTourist.Application.Features.Main.TreatmentType.Commands.UpdateTreatmentType;

public class UpdateTreatmentTypeCommand : IRequest<Unit>
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