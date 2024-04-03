using MediatR;

namespace HealthTourist.Application.Features.Main.TreatmentType.Queries.GetTreatmentTypes;

public record GetTreatmentTypesQuery : IRequest<List<GetTreatmentTypesDto>>;