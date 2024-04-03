using MediatR;

namespace HealthTourist.Application.Features.Main.Faq.Queries.GetFaqs;

public record GetFaqsQuery : IRequest<List<GetFaqsDto>>;
