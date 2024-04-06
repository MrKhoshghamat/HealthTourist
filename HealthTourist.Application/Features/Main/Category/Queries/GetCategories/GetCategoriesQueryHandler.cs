using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using HealthTourist.Common.Exceptions;
using MediatR;

namespace HealthTourist.Application.Features.Main.Category.Queries.GetCategories;

public class GetCategoriesQueryHandler(ICategoryRepository categoryRepository, IMapper mapper)
: IRequestHandler<GetCategoriesQuery, List<GetCategoriesDto>>
{
    public async Task<List<GetCategoriesDto>> Handle(GetCategoriesQuery request, CancellationToken cancellationToken)
    {
        if (request == null) throw new BadRequestException("Incoming request is not valid");
        var categories = await categoryRepository.GetAllAsync();
        if (categories == null) throw new NotFoundException(nameof(List<Domain.Main.Category>), request);

        var result = mapper.Map<List<GetCategoriesDto>>(categories);
        return result;
    }
}