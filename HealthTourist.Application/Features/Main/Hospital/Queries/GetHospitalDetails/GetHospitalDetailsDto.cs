using HealthTourist.Domain.Common;
using HealthTourist.Domain.Interface;
using HealthTourist.Domain.Main;

namespace HealthTourist.Application.Features.Main.Hospital.Queries.GetHospitalDetails;

public class GetHospitalDetailsDto
{
    #region Properties

    public int HospitalTypeId { get; set; }
    public string Name { get; set; }
    public string Title { get; set; }
    public int CityId { get; set; }
    public string Address { get; set; }
    public long Lat { get; set; }
    public long Long { get; set; }
    public string PostalCode { get; set; }
    public string PhoneNumber1 { get; set; }
    public string PhoneNumber2 { get; set; }
    public string PhoneNumber3 { get; set; }
    public string Email { get; set; }
    public int NumberOfBeds { get; set; }
    public string Description { get; set; }
    public DateOnly EstablishmentDate { get; set; }

    #endregion

    #region Relations

    public virtual Domain.Main.HospitalType HospitalType { get; set; }
    public virtual City City { get; set; }
    public virtual ICollection<Domain.Main.Doctor> Doctors { get; set; }
    public virtual ICollection<Health> Healths { get; set; }
    public virtual ICollection<HospitalAttachment> HospitalAttachments { get; set; }
    public virtual ICollection<HospitalGallery> HospitalGalleries { get; set; }
    public virtual ICollection<HospitalTag> HospitalTags { get; set; }

    #endregion
}