using HealthTourist.Domain.Account;
using MediatR;

namespace HealthTourist.Application.Features.Main.OfficeManager.Commands.CreateOfficeManager;

public class CreateOfficeManagerCommand : IRequest<long>
{
    public long PersonId { get; set; }
    public int OfficeId { get; set; }
}