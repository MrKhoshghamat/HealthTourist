using HealthTourist.Domain.Account;
using HealthTourist.Domain.Interface;

namespace HealthTourist.Application.Features.Main.Guest.Queries.GetGuestDetails;

public class GetGuestDetailsDto
{
    #region Properties

    public long PersonId { get; set; }

    #endregion

    #region Relations

    public virtual Person Person { get; set; }
    public virtual ICollection<TravelGuest> TravelGuests { get; set; }

    #endregion
}