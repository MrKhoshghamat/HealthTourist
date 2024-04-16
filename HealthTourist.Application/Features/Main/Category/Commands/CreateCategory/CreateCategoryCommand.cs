using HealthTourist.Domain.Interface;
using MediatR;

namespace HealthTourist.Application.Features.Main.Category.Commands.CreateCategory;

public class CreateCategoryCommand : IRequest<int>
{
    #region Properties

    public string Name { get; set; }
    public string Title { get; set; }

    #endregion

    #region Relations

    public virtual ICollection<SightseenCategory> SightseenCategories { get; set; }

    #endregion
}