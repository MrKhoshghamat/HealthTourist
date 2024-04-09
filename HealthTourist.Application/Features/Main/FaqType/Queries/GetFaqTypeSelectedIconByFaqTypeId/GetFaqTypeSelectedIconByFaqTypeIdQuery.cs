using MediatR;

namespace HealthTourist.Application.Features.Main.FaqType.Queries.GetFaqTypeSelectedIconByFaqTypeId;

public record GetFaqTypeSelectedIconByFaqTypeIdQuery(int FaqTypeId, bool IsSelected = true) : IRequest<GetFaqTypeSelectedIconByFaqTypeIdDto>;
