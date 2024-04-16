using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using MediatR;

namespace HealthTourist.Application.Features.Main.Category.Commands.UpdateCategory;

public class UpdateCategoryCommandValidator(ICategoryRepository categoryRepository, IMapper mapper)
: IRequestHandler<UpdateCategoryCommand, Unit>
{
    public async Task<Unit> Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
    {
        var category = mapper.Map<Domain.Main.Category>(request);
        await categoryRepository.UpdateAsync(category);
        return Unit.Value;
    }
}