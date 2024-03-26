using HealthTourist.Domain.Common;

namespace HealthTourist.Domain.Main;

public class Hospital : BaseEntity<int>
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

    public virtual HospitalType HospitalType { get; set; }
    public virtual City City { get; set; }
    public virtual ICollection<Doctor> Doctors { get; set; }
    public virtual ICollection<Health> Healths { get; set; }

    #endregion
}