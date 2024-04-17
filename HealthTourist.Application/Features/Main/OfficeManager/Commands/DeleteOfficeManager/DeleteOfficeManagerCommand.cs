using HealthTourist.Domain.Account;
using MediatR;

namespace HealthTourist.Application.Features.Main.OfficeManager.Commands.DeleteOfficeManager;

public class DeleteOfficeManagerCommand : IRequest<Unit>
{
    public long PersonId { get; set; }
    public int OfficeId { get; set; }
}

public record DeleteOfficeManagerByIdCommand(long Id) : IRequest<Unit>;