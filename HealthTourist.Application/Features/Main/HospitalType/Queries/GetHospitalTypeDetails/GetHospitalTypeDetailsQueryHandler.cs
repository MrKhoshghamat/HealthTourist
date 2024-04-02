using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using HealthTourist.Common.Exceptions;
using MediatR;

namespace HealthTourist.Application.Features.Main.HospitalType.Queries.GetHospitalTypeDetails;

public class GetHospitalTypeDetailsQueryHandler(IHospitalTypeRepository hospitalTypeRepository, IMapper mapper)
    : IRequestHandler<GetHospitalTypeDetailsQuery, GetHospitalTypeDetailsDto>
{
    public async Task<GetHospitalTypeDetailsDto> Handle(GetHospitalTypeDetailsQuery request,
        CancellationToken cancellationToken)
    {
        if (request == null) throw new BadRequestException("Incoming request is not valid");
        var hospitalTypeDetails = await hospitalTypeRepository.FindAsync(request.Id);
        if (hospitalTypeDetails == null) throw new NotFoundException(nameof(Domain.Main.HospitalType), request.Id);

        var result = mapper.Map<GetHospitalTypeDetailsDto>(hospitalTypeDetails);
        return result;
    }
}