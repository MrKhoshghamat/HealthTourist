using MediatR;

namespace HealthTourist.Application.Features.Main.Hospital.Queries.GetHospitalTagsByHospitalId;

public record GetHospitalTagsByHospitalIdQuery(int HospitalId) : IRequest<List<GetHospitalTagsByHospitalIdDto>>;
