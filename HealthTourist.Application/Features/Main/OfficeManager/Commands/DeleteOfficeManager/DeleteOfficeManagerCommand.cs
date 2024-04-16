using HealthTourist.Domain.Account;
using MediatR;

namespace HealthTourist.Application.Features.Main.OfficeManager.Commands.DeleteOfficeManager;

public class DeleteOfficeManagerCommand : IRequest<Unit>
{
    #region Properties

    public long PersonId { get; set; }
    public int OfficeId { get; set; }

    #endregion

    #region Relations

    public virtual Person Person { get; set; }
    public virtual Domain.Main.Office Office { get; set; }

    #endregion
}