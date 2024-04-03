using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using HealthTourist.Common.Exceptions;
using MediatR;

namespace HealthTourist.Application.Features.Main.Hospital.Queries.GetHospitals;

public class GetHospitalsQueryHandler(IHospitalRepository hospitalRepository, IMapper mapper)
    : IRequestHandler<GetHospitalsQuery, List<GetHospitalsDto>>
{
    public async Task<List<GetHospitalsDto>> Handle(GetHospitalsQuery request, CancellationToken cancellationToken)
    {
        if (request == null) throw new BadRequestException("Incoming request is not valid");
        var hospitals = await hospitalRepository.GetAllAsync();
        if (hospitals == null) throw new NotFoundException(nameof(List<Domain.Main.Hospital>), request);

        var result = mapper.Map<List<GetHospitalsDto>>(hospitals);
        return result;
    }
}