using MediatR;

namespace HealthTourist.Application.Features.Main.Doctor.Queries.GetDoctors;

public record GetDoctorsQuery : IRequest<List<GetDoctorsDto>>;
