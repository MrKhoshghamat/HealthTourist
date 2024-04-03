namespace HealthTourist.Application.Features.Main.HospitalType.Queries.GetHospitalTypes;

public class GetHospitalTypesDto
{
    #region Properties

    public string Name { get; set; }
    public string Title { get; set; }

    #endregion

    #region Relations

    public virtual ICollection<Domain.Main.Hospital> Hospitals { get; set; }

    #endregion
}