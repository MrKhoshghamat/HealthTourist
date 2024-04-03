using MediatR;

namespace HealthTourist.Application.Features.Main.Hospital.Queries.GetHospitalDetails;

public record GetHospitalDetailsQuery(int Id) : IRequest<GetHospitalDetailsDto>;
