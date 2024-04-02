using MediatR;

namespace HealthTourist.Application.Features.Main.Doctor.Queries.GetDoctorDetails;

public record GetDoctorDetailsQuery(long Id) : IRequest<GetDoctorDetailsDto>;
