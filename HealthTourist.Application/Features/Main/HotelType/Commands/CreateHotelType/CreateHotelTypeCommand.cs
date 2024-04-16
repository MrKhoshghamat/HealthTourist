using MediatR;

namespace HealthTourist.Application.Features.Main.HotelType.Commands.CreateHotelType;

public class CreateHotelTypeCommand : IRequest<int>
{
    #region Properties

    public string Name { get; set; }
    public string Title { get; set; }

    #endregion

    #region Relations

    public virtual ICollection<Domain.Main.HotelRank> HotelRanks { get; set; }

    #endregion
}