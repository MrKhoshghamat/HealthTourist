using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using HealthTourist.Common.Exceptions;
using MediatR;

namespace HealthTourist.Application.Features.Main.Doctor.Queries.GetDoctors;

public class GetDoctorsQueryHandler(IDoctorRepository doctorRepository, IMapper mapper)
    : IRequestHandler<GetDoctorsQuery, List<GetDoctorsDto>>
{
    public async Task<List<GetDoctorsDto>> Handle(GetDoctorsQuery request, CancellationToken cancellationToken)
    {
        if (request == null) throw new BadRequestException("Incoming request is not valid");
        var doctors = await doctorRepository.GetAllAsync();
        if (doctors == null) throw new NotFoundException(nameof(List<Domain.Main.Doctor>), request);

        var result = mapper.Map<List<GetDoctorsDto>>(doctors);
        return result;
    }
}