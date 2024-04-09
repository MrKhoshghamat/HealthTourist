using MediatR;

namespace HealthTourist.Application.Features.Main.TreatmentType.Queries.GetTreatmentTypeIconByTreatmentTypeId;

public record GetTreatmentTypeIconByTreatmentTypeIdQuery(int TreatmentTypeId)
    : IRequest<GetTreatmentTypeIconByTreatmentTypeIdDto>;
