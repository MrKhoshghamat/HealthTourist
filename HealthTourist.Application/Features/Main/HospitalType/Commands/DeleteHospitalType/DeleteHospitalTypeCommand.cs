using MediatR;

namespace HealthTourist.Application.Features.Main.HospitalType.Commands.DeleteHospitalType;

public class DeleteHospitalTypeCommand : IRequest<Unit>
{
    #region Properties

    public string Name { get; set; }
    public string Title { get; set; }

    #endregion

    #region Relations

    public virtual ICollection<Domain.Main.Hospital> Hospitals { get; set; }

    #endregion
}