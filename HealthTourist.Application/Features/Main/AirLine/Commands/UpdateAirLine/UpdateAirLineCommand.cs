using MediatR;

namespace HealthTourist.Application.Features.Main.AirLine.Commands.UpdateAirLine;

public class UpdateAirLineCommand : IRequest<Unit>
{
    #region Properties

    public string Name { get; set; }
    public string Title { get; set; }

    #endregion

    #region Relations

    public virtual ICollection<Domain.Main.Travel> Travels { get; set; }

    #endregion
}