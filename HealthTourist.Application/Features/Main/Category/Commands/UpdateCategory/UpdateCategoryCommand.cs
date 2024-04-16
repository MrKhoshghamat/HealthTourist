using HealthTourist.Domain.Interface;
using MediatR;

namespace HealthTourist.Application.Features.Main.Category.Commands.UpdateCategory;

public class UpdateCategoryCommand : IRequest<Unit>
{
    #region Properties

    public string Name { get; set; }
    public string Title { get; set; }

    #endregion

    #region Relations

    public virtual ICollection<SightseenCategory> SightseenCategories { get; set; }

    #endregion
}