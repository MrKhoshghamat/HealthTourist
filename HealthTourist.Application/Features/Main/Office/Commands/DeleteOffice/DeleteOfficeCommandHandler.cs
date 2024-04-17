using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using MediatR;

namespace HealthTourist.Application.Features.Main.Office.Commands.DeleteOffice;

public class DeleteOfficeCommandHandler(IOfficeRepository officeRepository, IMapper mapper)
    : IRequestHandler<DeleteOfficeCommand, Unit>
{
    public async Task<Unit> Handle(DeleteOfficeCommand request, CancellationToken cancellationToken)
    {
        var office = mapper.Map<Domain.Main.Office>(request);
        await officeRepository.DeleteAsync(office);
        return Unit.Value;
    }
    
    public async Task<Unit> Handle(DeleteOfficeByIdCommand request, CancellationToken cancellationToken)
    {
        var office = mapper.Map<Domain.Main.Office>(request);
        await officeRepository.DeleteAsync(office);
        return Unit.Value;
    }
}