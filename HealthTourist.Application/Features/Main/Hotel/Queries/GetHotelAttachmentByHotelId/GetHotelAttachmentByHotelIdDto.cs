namespace HealthTourist.Application.Features.Main.Hotel.Queries.GetHotelAttachmentByHotelId;

public class GetHotelAttachmentByHotelIdDto
{
    public int HotelId { get; set; }
    public Guid AttachmentId { get; set; }
    public byte[] Content { get; set; }
}