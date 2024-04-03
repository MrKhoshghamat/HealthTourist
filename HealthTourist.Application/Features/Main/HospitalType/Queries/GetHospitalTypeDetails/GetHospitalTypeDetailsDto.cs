namespace HealthTourist.Application.Features.Main.HospitalType.Queries.GetHospitalTypeDetails;

public class GetHospitalTypeDetailsDto
{
    #region Properties

    public string Name { get; set; }
    public string Title { get; set; }

    #endregion

    #region Relations

    public virtual ICollection<Domain.Main.Hospital> Hospitals { get; set; }

    #endregion
}