namespace HealthTourist.Application.Features.Main.AirLine.Queries.GetAirLines;

public class GetAirLinesDto
{
    #region Properties

    public string Name { get; set; }
    public string Title { get; set; }

    #endregion

    #region Relations

    public virtual ICollection<Domain.Main.Travel> Travels { get; set; }

    #endregion
}