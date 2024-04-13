using HealthTourist.Domain.Common;
using HealthTourist.Domain.Main;

namespace HealthTourist.Application.Features.Common.City.Queries.GetCities;

public class GetCitiesDto
{
    #region Properties

    public int Id { get; set; }
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

    #endregion
}