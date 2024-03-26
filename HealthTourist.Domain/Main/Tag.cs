using HealthTourist.Domain.Interface;

namespace HealthTourist.Domain.Main;

public class Tag : BaseEntity<int>
{
    #region Properties

    public string Name { get; set; }
    public string Title { get; set; }

    #endregion

    #region Relations

    public virtual ICollection<HospitalTag> HospitalTags { get; set; }
    public virtual ICollection<HotelTag> HotelTags { get; set; }

    #endregion
}