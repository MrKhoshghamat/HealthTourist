using HealthTourist.Application.Features.Main.Faq.Queries.GetFaqs;
using MediatR;

namespace HealthTourist.Application.Features.Main.Faq.Queries.GetFaqDetails;

public record GetFaqDetailsQuery(int Id) : IRequest<GetFaqDetailsDto>;