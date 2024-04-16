using MediatR;

namespace HealthTourist.Application.Features.Main.AirLine.Commands.DeleteAirLine;

public class DeleteAirLineCommand : IRequest<Unit>
{
    #region Properties

    public string Name { get; set; }
    public string Title { get; set; }

    #endregion

    #region Relations

    public virtual ICollection<Domain.Main.Travel> Travels { get; set; }

    #endregion
}