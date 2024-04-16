using HealthTourist.Domain.Common;
using HealthTourist.Domain.Interface;
using MediatR;

namespace HealthTourist.Application.Features.Main.Hotel.Commands.CreateHotel;

public class CreateHotelCommand : IRequest<int>
{
    #region Properties

    public int HotelRankId { get; set; }
    public string Name { get; set; }
    public string Title { get; set; }
    public int CityId { get; set; }
    public string Address { get; set; }
    public long Lat { get; set; }
    public long Long { get; set; }
    public string PostalCode { get; set; }
    public string PhoneNumber1 { get; set; }
    public string PhoneNumber2 { get; set; }
    public string PhoneNumber3 { get; set; }
    public string Website { get; set; }
    public string Email { get; set; }
    public TimeOnly CheckInTime { get; set; }
    public TimeOnly CheckOutTime { get; set; }
    public int NumberOfRooms { get; set; }
    public string Description { get; set; }
    public DateOnly EstablishmentDate { get; set; }

    #endregion

    #region Relations

    public virtual Domain.Main.HotelRank HotelRank { get; set; }
    public virtual City City { get; set; }
    public virtual ICollection<Domain.Main.Travel> Travels { get; set; }
    public virtual ICollection<HotelAttachment> HotelAttachments { get; set; }
    public virtual ICollection<HotelGallery> HotelGalleries { get; set; }
    public virtual ICollection<HotelTag> HotelTags { get; set; }

    #endregion
}