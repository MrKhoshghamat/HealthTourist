using HealthTourist.Domain.Interface;

namespace HealthTourist.Application.Features.Main.Category.Queries.GetCategoryDetails;

public class GetCategoryDetailsDto
{
    #region Properties

    public string Name { get; set; }
    public string Title { get; set; }

    #endregion

    #region Relations

    public virtual ICollection<SightseenCategory> SightseenCategories { get; set; }

    #endregion
}