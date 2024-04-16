using MediatR;

namespace HealthTourist.Application.Features.Common.State.Commands.UpdateState;

public class UpdateStateCommand : IRequest<Unit>
{
    #region Properties

    public int CountryId { get; set; }
    public string Name { get; set; }
    public string Title { get; set; }

    #endregion

    #region Relations

    public virtual Domain.Common.Country Country { get; set; }
    public virtual ICollection<Domain.Common.City> Cities { get; set; }

    #endregion
}