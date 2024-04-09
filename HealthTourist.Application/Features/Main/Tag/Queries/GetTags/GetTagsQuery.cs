using MediatR;

namespace HealthTourist.Application.Features.Main.Tag.Queries.GetTags;

public record GetTagsQuery : IRequest<List<GetTagsDto>>;
