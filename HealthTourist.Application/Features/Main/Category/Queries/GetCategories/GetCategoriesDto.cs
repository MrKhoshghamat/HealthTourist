using HealthTourist.Domain.Interface;

namespace HealthTourist.Application.Features.Main.Category.Queries.GetCategories;

public class GetCategoriesDto
{
    #region Properties

    public string Name { get; set; }
    public string Title { get; set; }

    #endregion

    #region Relations

    public virtual ICollection<SightseenCategory> SightseenCategories { get; set; }

    #endregion
}