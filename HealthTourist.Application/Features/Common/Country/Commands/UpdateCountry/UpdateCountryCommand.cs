using HealthTourist.Domain.Main;
using MediatR;

namespace HealthTourist.Application.Features.Common.Country.Commands.UpdateCountry;

public class UpdateCountryCommand : IRequest<Unit>
{
    #region Properties

    public string Name { get; set; }
    public string Title { get; set; }
    public string Code { get; set; }

    #endregion

    #region Relations

    public virtual ICollection<Domain.Common.State> States { get; set; }
    public virtual ICollection<Office> Offices { get; set; }

    #endregion
}