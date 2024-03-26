using HealthTourist.Domain.Interface;

namespace HealthTourist.Domain.Main;

public class Category : BaseEntity<int>
{
    #region Properties

    public string Name { get; set; }
    public string Title { get; set; }

    #endregion

    #region Relations

    public virtual ICollection<SightseenCategory> SightseenCategories { get; set; }

    #endregion
}