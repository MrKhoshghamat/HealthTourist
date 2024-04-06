using MediatR;

namespace HealthTourist.Application.Features.Main.Category.Queries.GetCategories;

public record GetCategoriesQuery : IRequest<List<GetCategoriesDto>>;
