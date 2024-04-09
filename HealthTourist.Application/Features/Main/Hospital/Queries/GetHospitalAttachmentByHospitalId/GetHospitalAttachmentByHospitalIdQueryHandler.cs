using AutoMapper;
using HealthTourist.Application.Contracts.Interface;
using HealthTourist.Common.Exceptions;
using HealthTourist.Domain.Interface;
using MediatR;

namespace HealthTourist.Application.Features.Main.Hospital.Queries.GetHospitalAttachmentByHospitalId;

public class GetHospitalAttachmentByHospitalIdQueryHandler(
    IHospitalAttachmentRepository hospitalAttachmentRepository,
    IMapper mapper)
    : IRequestHandler<GetHospitalAttachmentByHospitalIdQuery, List<GetHospitalAttachmentByHospitalIdDto>>
{
    public async Task<List<GetHospitalAttachmentByHospitalIdDto>> Handle(GetHospitalAttachmentByHospitalIdQuery request,
        CancellationToken cancellationToken)
    {
        if (request == null) throw new BadRequestException("Incoming request is not valid");
        var hospitalAttachment =
            await hospitalAttachmentRepository.GetAllAsync(ha => ha.HospitalId == request.HospitalId);
        if (hospitalAttachment == null) throw new NotFoundException(nameof(HospitalAttachment), request.HospitalId);

        var result = mapper.Map<List<GetHospitalAttachmentByHospitalIdDto>>(hospitalAttachment);
        return result;
    }
}