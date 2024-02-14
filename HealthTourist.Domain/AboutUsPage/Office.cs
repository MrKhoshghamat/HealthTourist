using HealthTourist.Domain.Persistence;

namespace HealthTourist.Domain.AboutUsPage;

public class Office : BaseEntity<int>
{
    #region Properties

    /// <summary>
    /// Office Name
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// Office Title
    /// </summary>
    public string Title { get; set; }
    
    /// <summary>
    /// Office Phone Number 1
    /// </summary>
    public string PhoneNumber1 { get; set; }
    
    /// <summary>
    /// Office Phone Number 2
    /// </summary>
    public string PhoneNumber2 { get; set; }
    
    /// <summary>
    /// Office Phone Number 3
    /// </summary>
    public string PhoneNumber3 { get; set; }

    /// <summary>
    /// Office Fax Number
    /// </summary>
    public string FaxNumber { get; set; }
    
    /// <summary>
    /// Office Email Address
    /// </summary>
    public string Email { get; set; }
    
    /// <summary>
    /// Office Address
    /// </summary>
    public string Address { get; set; }

    /// <summary>
    /// Office Postal Code
    /// </summary>
    public string PostalCode { get; set; }

    #endregion

    #region Relations

    /// <summary>
    /// Interface table between Office and Location
    /// </summary>
    public virtual ICollection<OfficeLocation> OfficeLocations { get; set; }

    #endregion
}