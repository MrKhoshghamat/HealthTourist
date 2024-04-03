using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using HealthTourist.Common.Exceptions;
using MediatR;

namespace HealthTourist.Application.Features.Main.HospitalType.Queries.GetHospitalTypes;

public class GetHospitalTypesQueryHandler(IHospitalTypeRepository hospitalTypeRepository, IMapper mapper)
    : IRequestHandler<GetHospitalTypesQuery, List<GetHospitalTypesDto>>
{
    public async Task<List<GetHospitalTypesDto>> Handle(GetHospitalTypesQuery request,
        CancellationToken cancellationToken)
    {
        if (request == null) throw new BadRequestException("Incoming request is not valid");
        var hospitalTypes = await hospitalTypeRepository.GetAllAsync();
        if (hospitalTypes == null) throw new NotFoundException(nameof(List<Domain.Main.HospitalType>), request);

        var result = mapper.Map<List<GetHospitalTypesDto>>(hospitalTypes);
        return result;
    }
}