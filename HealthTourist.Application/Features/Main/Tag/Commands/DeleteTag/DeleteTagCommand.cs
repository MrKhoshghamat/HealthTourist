using HealthTourist.Domain.Interface;
using MediatR;

namespace HealthTourist.Application.Features.Main.Tag.Commands.DeleteTag;

public class DeleteTagCommand : IRequest<Unit>
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