using MediatR;

namespace HealthTourist.Application.Features.Main.Category.Queries.GetCategoryDetails;

public record GetCategoryDetailsQuery(int Id) : IRequest<GetCategoryDetailsDto>;
