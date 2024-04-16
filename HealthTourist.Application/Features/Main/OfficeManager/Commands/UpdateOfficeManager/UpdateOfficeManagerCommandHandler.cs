using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using MediatR;

namespace HealthTourist.Application.Features.Main.OfficeManager.Commands.UpdateOfficeManager;

public class UpdateOfficeManagerCommandHandler(IOfficeManagerRepository officeManagerRepository, IMapper mapper)
    : IRequestHandler<UpdateOfficeManagerCommand, Unit>
{
    public async Task<Unit> Handle(UpdateOfficeManagerCommand request, CancellationToken cancellationToken)
    {
        var officeManager = mapper.Map<Domain.Main.OfficeManager>(request);
        await officeManagerRepository.UpdateAsync(officeManager);
        return Unit.Value;
    }
}