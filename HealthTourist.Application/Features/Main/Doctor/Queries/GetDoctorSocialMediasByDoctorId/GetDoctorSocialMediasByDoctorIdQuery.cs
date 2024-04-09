using MediatR;

namespace HealthTourist.Application.Features.Main.Doctor.Queries.GetDoctorSocialMediasByDoctorId;

public record GetDoctorSocialMediasByDoctorIdQuery(long DoctorId) : IRequest<GetDoctorSocialMediasByDoctorIdDto>;
