using AutoMapper;
using HealthTourist.Application.Contracts.Interface;
using HealthTourist.Common.Exceptions;
using HealthTourist.Domain.Interface;
using MediatR;

namespace HealthTourist.Application.Features.Main.Doctor.Queries.GetDoctorAttachmentByDoctorId;

public class GetDoctorAttachmentByDoctorIdQueryHandler(IDoctorAttachmentRepository doctorAttachmentRepository, IMapper mapper)
: IRequestHandler<GetDoctorAttachmentByDoctorIdQuery, GetDoctorAttachmentByDoctorIdDto>
{
    public async Task<GetDoctorAttachmentByDoctorIdDto> Handle(GetDoctorAttachmentByDoctorIdQuery request, CancellationToken cancellationToken)
    {
        if (request == null) throw new BadRequestException("Incoming request is not valid");
        var doctorAttachment = await doctorAttachmentRepository.FindAsync(da => da.DoctorId == request.DoctorId);
        if (doctorAttachment == null) throw new NotFoundException(nameof(DoctorAttachment), request.DoctorId);

        var result = mapper.Map<GetDoctorAttachmentByDoctorIdDto>(doctorAttachment);
        return result;
    }
}