using MediatR;

namespace HealthTourist.Application.Features.Main.TreatmentType.Queries.GetTreatmentTypeDetails;

public record GetTreatmentTypeDetailsQuery(int Id) : IRequest<GetTreatmentTypeDetailsDto>;