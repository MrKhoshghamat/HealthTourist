using MediatR;

namespace HealthTourist.Application.Features.Main.Triage.Queries.GetTriages;

public record GetTriagesQuery : IRequest<List<GetTriagesDto>>;
