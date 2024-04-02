using MediatR;

namespace HealthTourist.Application.Features.Main.HospitalType.Queries.GetHospitalTypes;

public record GetHospitalTypesQuery : IRequest<List<GetHospitalTypesDto>>;
