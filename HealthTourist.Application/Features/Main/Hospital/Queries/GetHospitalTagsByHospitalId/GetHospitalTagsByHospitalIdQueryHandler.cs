using AutoMapper;
using HealthTourist.Application.Contracts.Interface;
using HealthTourist.Common.Exceptions;
using HealthTourist.Domain.Interface;
using MediatR;

namespace HealthTourist.Application.Features.Main.Hospital.Queries.GetHospitalTagsByHospitalId;

public class GetHospitalTagsByHospitalIdQueryHandler(IHospitalTagRepository hospitalTagRepository, IMapper mapper)
    : IRequestHandler<GetHospitalTagsByHospitalIdQuery, GetHospitalTagsByHospitalIdDto>
{
    public async Task<GetHospitalTagsByHospitalIdDto> Handle(GetHospitalTagsByHospitalIdQuery request,
        CancellationToken cancellationToken)
    {
        if (request == null) throw new BadRequestException("Incoming request is not valid");
        var hospitalTags = await hospitalTagRepository.GetAllAsync(ht => ht.HospitalId == request.HospitalId);
        if (hospitalTags == null) throw new NotFoundException(nameof(List<HospitalTag>), request.HospitalId);

        var result = mapper.Map<GetHospitalTagsByHospitalIdDto>(hospitalTags);
        return result;
    }
}