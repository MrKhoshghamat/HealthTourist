using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using MediatR;

namespace HealthTourist.Application.Features.Main.OfficeManager.Commands.DeleteOfficeManager;

public class DeleteOfficeManagerCommandHandler(IOfficeManagerRepository officeManagerRepository, IMapper mapper)
    : IRequestHandler<DeleteOfficeManagerCommand, Unit>
{
    public async Task<Unit> Handle(DeleteOfficeManagerCommand request, CancellationToken cancellationToken)
    {
        var officeManager = mapper.Map<Domain.Main.OfficeManager>(request);
        await officeManagerRepository.DeleteAsync(officeManager);
        return Unit.Value;
    }

    public async Task<Unit> Handle(DeleteOfficeManagerByIdCommand request, CancellationToken cancellationToken)
    {
        var officeManager = mapper.Map<Domain.Main.OfficeManager>(request);
        await officeManagerRepository.DeleteAsync(officeManager);
        return Unit.Value;
    }
}