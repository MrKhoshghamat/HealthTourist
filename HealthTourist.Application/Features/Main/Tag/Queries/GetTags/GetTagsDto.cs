using HealthTourist.Domain.Interface;

namespace HealthTourist.Application.Features.Main.Tag.Queries.GetTags;

public class GetTagsDto
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