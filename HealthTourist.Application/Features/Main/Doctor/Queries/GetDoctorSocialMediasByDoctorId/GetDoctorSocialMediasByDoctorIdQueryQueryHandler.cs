using AutoMapper;
using HealthTourist.Application.Contracts.Interface;
using HealthTourist.Common.Exceptions;
using HealthTourist.Domain.Interface;
using MediatR;

namespace HealthTourist.Application.Features.Main.Doctor.Queries.GetDoctorSocialMediasByDoctorId;

public class GetDoctorSocialMediasByDoctorIdQueryQueryHandler(
    IDoctorSocialMediaRepository doctorSocialMediaRepository,
    IMapper mapper)
    : IRequestHandler<GetDoctorSocialMediasByDoctorIdQuery, GetDoctorSocialMediasByDoctorIdDto>
{
    public async Task<GetDoctorSocialMediasByDoctorIdDto> Handle(GetDoctorSocialMediasByDoctorIdQuery request,
        CancellationToken cancellationToken)
    {
        if (request == null) throw new BadRequestException("Incoming request is not valid");
        var doctorSocialMedia = await doctorSocialMediaRepository.FindAsync(dsm => dsm.DoctorId == request.DoctorId);
        if (doctorSocialMedia == null) throw new NotFoundException(nameof(DoctorSocialMedia), request.DoctorId);

        var result = mapper.Map<GetDoctorSocialMediasByDoctorIdDto>(doctorSocialMedia);
        return result;
    }
}