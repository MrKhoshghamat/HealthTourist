using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using HealthTourist.Common.Exceptions;
using MediatR;

namespace HealthTourist.Application.Features.Main.Doctor.Queries.GetDoctorDetails;

public class GetDoctorDetailsQueryHandler(IDoctorRepository doctorRepository, IMapper mapper)
    : IRequestHandler<GetDoctorDetailsQuery, GetDoctorDetailsDto>
{
    public async Task<GetDoctorDetailsDto> Handle(GetDoctorDetailsQuery request, CancellationToken cancellationToken)
    {
        if (request == null) throw new BadRequestException("Incoming request is not valid");
        var doctorDetails = await doctorRepository.FindAsync(request.Id);
        if (doctorDetails == null) throw new NotFoundException(nameof(Domain.Main.Doctor), request.Id);

        var result = mapper.Map<GetDoctorDetailsDto>(doctorDetails);
        return result;
    }
}