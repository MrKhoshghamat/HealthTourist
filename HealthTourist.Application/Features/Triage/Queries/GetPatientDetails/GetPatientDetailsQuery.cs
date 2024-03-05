using MediatR;

namespace HealthTourist.Application.Features.Triage.Queries.GetPatientDetails;

public record GetPatientDetailsQuery(long Id) : IRequest<GetPatientDetailsDto>;