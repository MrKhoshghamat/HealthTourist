using HealthTourist.Domain.Common;
using HealthTourist.Domain.Main;

namespace HealthTourist.Application.Features.Common.Country.Queries.GetCountryDetails;

public class GetCountryDetailsDto
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