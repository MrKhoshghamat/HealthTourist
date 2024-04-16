using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using MediatR;

namespace HealthTourist.Application.Features.Main.Office.Commands.CreateOffice;

public class CreateOfficeCommandHandler(IOfficeRepository officeRepository, IMapper mapper)
    : IRequestHandler<CreateOfficeCommand, int>
{
    public async Task<int> Handle(CreateOfficeCommand request, CancellationToken cancellationToken)
    {
        var office = mapper.Map<Domain.Main.Office>(request);
        await officeRepository.CreateAsync(office);
        return office.Id;
    }
}