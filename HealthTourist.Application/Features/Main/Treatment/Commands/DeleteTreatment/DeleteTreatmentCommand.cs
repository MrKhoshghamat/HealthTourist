using MediatR;

namespace HealthTourist.Application.Features.Main.Treatment.Commands.DeleteTreatment;

public class DeleteTreatmentCommand : IRequest<Unit>
{
    #region Properties

    public int TreatmentTypeId { get; set; }
    public string Name { get; set; }
    public string Title { get; set; }

    #endregion

    #region Relations

    public virtual Domain.Main.TreatmentType TreatmentType { get; set; }
    public virtual ICollection<Domain.Main.Doctor> Doctors { get; set; }
    public virtual ICollection<Domain.Main.TeamMember> TeamMembers { get; set; }
    public virtual ICollection<Domain.Main.Triage> Triages { get; set; }

    #endregion
}