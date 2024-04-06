namespace HealthTourist.Application.Features.Common.State.Queries.GetStateDetails;

public class GetStateDetailsDto
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