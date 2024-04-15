using MediatR;

namespace HealthTourist.Application.Features.Main.Faq.Queries.GetFaqsByFaqTypeId;

public record GetFaqsByFaqTypeIdQuery(int FaqTypeId) : IRequest<List<GetFaqsByFaqTypeIdDto>>;
