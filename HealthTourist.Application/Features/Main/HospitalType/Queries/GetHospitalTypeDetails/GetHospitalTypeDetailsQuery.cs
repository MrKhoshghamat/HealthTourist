using MediatR;

namespace HealthTourist.Application.Features.Main.HospitalType.Queries.GetHospitalTypeDetails;

public record GetHospitalTypeDetailsQuery(int Id) : IRequest<GetHospitalTypeDetailsDto>;
