using HealthTourist.Common.Enumerations.Common;
using HealthTourist.Domain.Department;
using HealthTourist.Domain.Persistence;

namespace HealthTourist.Domain.Account;

public class Person : BaseEntity<long>
{
    #region Properties

    /// <summary>
    /// National Code 
    /// </summary>
    public string NationalCode { get; set; }
    
    /// <summary>
    /// First Name
    /// </summary>
    public string FirstName { get; set; }
    
    /// <summary>
    /// Last Name
    /// </summary>
    public string LastName { get; set; }
    
    /// <summary>
    /// Birth Date
    /// </summary>
    public DateTime BirthDate { get; set; }

    /// <summary>
    /// Gender
    /// </summary>
    public GenderEnum Gender { get; set; }
    
    /// <summary>
    /// Phone Number
    /// </summary>
    public string PhoneNumber { get; set; }
    
    /// <summary>
    /// Email
    /// </summary>
    public string Email { get; set; }
    
    /// <summary>
    /// Address
    /// </summary>
    public string Address { get; set; }

    #endregion

    #region Relations

    /// <summary>
    /// Person Attachments
    /// </summary>
    public virtual ICollection<PersonAttachment> PersonAttachments { get; set; }
    
    /// <summary>
    /// Team Member
    /// </summary>
    public virtual TeamMember TeamMember { get; set; }

    /// <summary>
    /// Patient
    /// </summary>
    public virtual Patient Patient { get; set; }

    #endregion
}