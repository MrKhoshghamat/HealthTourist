using MediatR;

namespace HealthTourist.Application.Features.Main.AirLine.Commands.CreateAirLine;

public class CreateAirLineCommand : IRequest<int>
{
    #region Properties

    public string Name { get; set; }
    public string Title { get; set; }

    #endregion

    #region Relations

    public virtual ICollection<Domain.Main.Travel> Travels { get; set; }

    #endregion
}