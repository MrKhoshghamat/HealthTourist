using HealthTourist.Domain.Common;
using HealthTourist.Domain.Interface;

namespace HealthTourist.Domain.Main;

public class Office : BaseEntity<int>
{
    #region Properties

    public string Name { get; set; }
    public string Title { get; set; }
    public string Address { get; set; }
    public long Lat { get; set; }
    public long Long { get; set; }
    public int CountryId { get; set; }
    public int CityId { get; set; }
    public string PostalCode { get; set; }
    public string PhoneNumber1 { get; set; }
    public string PhoneNumber2 { get; set; }
    public string PhoneNumber3 { get; set; }
    public string Email { get; set; }
    public string OwnerCommission { get; set; }
    public string PresentedCommission { get; set; }

    #endregion

    #region Relations

    public virtual Country Country { get; set; }
    public virtual City City { get; set; }
    public virtual OfficeManager OfficeManager { get; set; }
    public virtual ICollection<OfficeAttachment> OfficeAttachments { get; set; }

    #endregion
}