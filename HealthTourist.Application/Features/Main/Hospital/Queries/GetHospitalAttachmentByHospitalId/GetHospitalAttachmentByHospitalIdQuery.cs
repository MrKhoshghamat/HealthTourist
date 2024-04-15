using MediatR;

namespace HealthTourist.Application.Features.Main.Hospital.Queries.GetHospitalAttachmentByHospitalId;

public record GetHospitalAttachmentByHospitalIdQuery(int HospitalId) : IRequest<GetHospitalAttachmentByHospitalIdDto>;
