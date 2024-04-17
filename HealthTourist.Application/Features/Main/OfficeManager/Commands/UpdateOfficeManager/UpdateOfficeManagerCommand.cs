using HealthTourist.Domain.Account;
using MediatR;

namespace HealthTourist.Application.Features.Main.OfficeManager.Commands.UpdateOfficeManager;

public class UpdateOfficeManagerCommand : IRequest<Unit>
{
    public long PersonId { get; set; }
    public int OfficeId { get; set; }
}