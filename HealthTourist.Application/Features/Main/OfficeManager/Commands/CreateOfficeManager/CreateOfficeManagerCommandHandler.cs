using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using MediatR;

namespace HealthTourist.Application.Features.Main.OfficeManager.Commands.CreateOfficeManager;

public class CreateOfficeManagerCommandHandler(IOfficeManagerRepository officeManagerRepository, IMapper mapper)
    : IRequestHandler<CreateOfficeManagerCommand, long>
{
    public async Task<long> Handle(CreateOfficeManagerCommand request, CancellationToken cancellationToken)
    {
        var officeManager = mapper.Map<Domain.Main.OfficeManager>(request);
        await officeManagerRepository.CreateAsync(officeManager);
        return officeManager.Id;
    }
}