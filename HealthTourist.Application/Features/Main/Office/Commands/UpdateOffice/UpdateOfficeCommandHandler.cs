using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using HealthTourist.Application.Features.Main.Office.Commands.DeleteOffice;
using MediatR;

namespace HealthTourist.Application.Features.Main.Office.Commands.UpdateOffice;

public class UpdateOfficeCommandHandler(IOfficeRepository officeRepository, IMapper mapper)
    : IRequestHandler<DeleteOfficeCommand, Unit>
{
    public async Task<Unit> Handle(DeleteOfficeCommand request, CancellationToken cancellationToken)
    {
        var office = mapper.Map<Domain.Main.Office>(request);
        await officeRepository.UpdateAsync(office);
        return Unit.Value;
    }
}