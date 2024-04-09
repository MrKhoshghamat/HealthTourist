using MediatR;

namespace HealthTourist.Application.Features.Main.Doctor.Queries.GetDoctorAttachmentByDoctorId;

public record GetDoctorAttachmentByDoctorIdQuery(long DoctorId) : IRequest<GetDoctorAttachmentByDoctorIdDto>;