using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using HealthTourist.Common.Exceptions;
using MediatR;

namespace HealthTourist.Application.Features.Main.Office.Queries.GetOffices;

public class GetOfficesQueryHandler(IOfficeRepository officeRepository, IMapper mapper)
    : IRequestHandler<GetOfficesQuery, List<GetOfficesDto>>
{
    public async Task<List<GetOfficesDto>> Handle(GetOfficesQuery request, CancellationToken cancellationToken)
    {
        if (request == null) throw new BadRequestException("Incoming request is not valid");
        var offices = await officeRepository.GetAllAsync();
        if (offices == null) throw new NotFoundException(nameof(List<Domain.Main.Office>), request);

        var result = mapper.Map<List<GetOfficesDto>>(offices);
        return result;
    }
}