using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using HealthTourist.Common.Exceptions;
using MediatR;

namespace HealthTourist.Application.Features.Main.Hospital.Queries.GetHospitalDetails;

public class GetHospitalDetailsQueryHandler(IHospitalRepository hospitalRepository, IMapper mapper)
    : IRequestHandler<GetHospitalDetailsQuery, GetHospitalDetailsDto>
{
    public async Task<GetHospitalDetailsDto> Handle(GetHospitalDetailsQuery request,
        CancellationToken cancellationToken)
    {
        if (request == null) throw new BadRequestException("Incoming request is not valid");
        var hospitalDetails = await hospitalRepository.FindAsync(request.Id);
        if (hospitalDetails == null) throw new NotFoundException(nameof(Domain.Main.Hospital), request.Id);

        var result = mapper.Map<GetHospitalDetailsDto>(hospitalDetails);
        return result;
    }
}