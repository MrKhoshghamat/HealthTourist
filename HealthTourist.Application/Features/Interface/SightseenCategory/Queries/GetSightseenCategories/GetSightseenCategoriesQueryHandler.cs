using AutoMapper;
using HealthTourist.Application.Contracts.Interface;
using HealthTourist.Common.Exceptions;
using MediatR;

namespace HealthTourist.Application.Features.Interface.SightseenCategory.Queries.GetSightseenCategories;

public class GetSightseenCategoriesQueryHandler(ISightseenCategoryRepository sightseenCategoryRepository, IMapper mapper)
: IRequestHandler<GetSightseenCategoriesQuery, List<GetSightseenCategoriesDto>>
{
    public async Task<List<GetSightseenCategoriesDto>> Handle(GetSightseenCategoriesQuery request, CancellationToken cancellationToken)
    {
        if (request == null) throw new BadRequestException("Incoming request is not valid");
        var sightseenCategories = await sightseenCategoryRepository.GetAllAsync();
        if (sightseenCategories == null)
            throw new NotFoundException(nameof(List<Domain.Interface.SightseenCategory>), request);

        var result = mapper.Map<List<GetSightseenCategoriesDto>>(sightseenCategories);
        return result;
    }
}