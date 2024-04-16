using HealthTourist.Domain.Interface;
using HealthTourist.Domain.Main;
using MediatR;

namespace HealthTourist.Application.Features.Common.City.Commands.CreateCity;

public class CreateCityCommand : IRequest<int>
{
    #region Properties

    public int StateId { get; set; }
    public string Name { get; set; }
    public string Title { get; set; }

    #endregion

    #region Relations

    public virtual Domain.Common.State State { get; set; }
    public virtual ICollection<Hospital> Hospitals { get; set; }
    public virtual ICollection<Hotel> Hotels { get; set; }
    public virtual ICollection<Office> Offices { get; set; }
    public virtual ICollection<Sightseen> Sightseens { get; set; }
    public virtual ICollection<CityAttachment> CityAttachments { get; set; }

    #endregion
}