using HealthTourist.Common.Enumerations.Common;
using HealthTourist.Domain.Main;
using MediatR;

namespace HealthTourist.Application.Features.Account.Person.Commands.DeletePerson;

public class DeletePersonCommand : IRequest<Unit>
{
    #region Properties

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public GenderEnum Gender { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
    public bool IsPatient { get; set; }
    public bool IsGuest { get; set; }
    public bool IsDoctor { get; set; }
    public bool IsAdmin { get; set; }

    #endregion

    #region Relations

    public virtual Doctor Doctor { get; set; }
    public virtual Guest Guest { get; set; }
    public virtual Patient Patient { get; set; }
    public virtual TeamMember TeamMember { get; set; }
    public virtual OfficeManager OfficeManager { get; set; }

    #endregion
}