using HealthTourist.Domain.Main;

namespace HealthTourist.Application.Features.Interface.SightseenCategory.Queries.GetSightseenCategories;

public class GetSightseenCategoriesDto
{
    #region Properties

    public int SightseenId { get; set; }
    public int CategoryId { get; set; }

    #endregion

    #region Relations

    public virtual Sightseen Sightseen { get; set; }
    public virtual Category Category { get; set; }

    #endregion
}