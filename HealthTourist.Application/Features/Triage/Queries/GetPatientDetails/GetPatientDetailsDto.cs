using HealthTourist.Common.Enumerations.Common;

namespace HealthTourist.Application.Features.Triage.Queries.GetPatientDetails;

public class GetPatientDetailsDto
{
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

    /// <summary>
    /// Height
    /// </summary>
    public string Height { get; set; }
    
    /// <summary>
    /// Weight
    /// </summary>
    public string Weight { get; set; }
    
    /// <summary>
    /// Description in Triage Form
    /// </summary>
    public string Description { get; set; }
}