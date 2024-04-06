using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using HealthTourist.Common.Exceptions;
using MediatR;

namespace HealthTourist.Application.Features.Main.Category.Queries.GetCategoryDetails;

public class GetCategoryDetailsQueryHandler(ICategoryRepository categoryRepository, IMapper mapper)
    : IRequestHandler<GetCategoryDetailsQuery, GetCategoryDetailsDto>
{
    public async Task<GetCategoryDetailsDto> Handle(GetCategoryDetailsQuery request,
        CancellationToken cancellationToken)
    {
        if (request == null) throw new BadRequestException("Incoming request is not valid");
        var category = await categoryRepository.FindAsync(request.Id);
        if (category == null) throw new NotFoundException(nameof(Domain.Main.Category), request.Id);

        var result = mapper.Map<GetCategoryDetailsDto>(category);
        return result;
    }
}