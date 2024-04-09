using MediatR;

namespace HealthTourist.Application.Features.Main.FaqType.Queries.GetFaqTypeIconByFaqTypeId;

public record GetFaqTypeIconByFaqTypeIdQuery(int FaqTypeId) : IRequest<GetFaqTypeIconByFaqTypeIdDto>;
