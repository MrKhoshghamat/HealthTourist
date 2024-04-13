using MediatR;

namespace HealthTourist.Application.Features.Interface.SightseenCategory.Queries.GetSightseenCategories;

public record GetSightseenCategoriesQuery : IRequest<List<GetSightseenCategoriesDto>>;
