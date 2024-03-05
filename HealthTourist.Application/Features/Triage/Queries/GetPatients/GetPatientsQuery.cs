using MediatR;

namespace HealthTourist.Application.Features.Triage.Queries.GetPatients;

public record GetPatientsQuery : IRequest<List<GetPatientsDto>>;