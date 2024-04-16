using MediatR;

namespace HealthTourist.Application.Features.Main.HotelType.Commands.UpdateHotelType;

public class UpdateHotelTypeCommand : IRequest<Unit>
{
    #region Properties

    public string Name { get; set; }
    public string Title { get; set; }

    #endregion

    #region Relations

    public virtual ICollection<Domain.Main.HotelRank> HotelRanks { get; set; }

    #endregion
}