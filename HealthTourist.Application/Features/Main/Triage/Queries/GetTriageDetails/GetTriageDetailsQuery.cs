using MediatR;

namespace HealthTourist.Application.Features.Main.Triage.Queries.GetTriageDetails;

public record GetTriageDetailsQuery(Guid Id) : IRequest<GetTriageDetailsDto>;