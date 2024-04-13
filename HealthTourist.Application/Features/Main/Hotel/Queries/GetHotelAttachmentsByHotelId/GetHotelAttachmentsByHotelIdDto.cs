namespace HealthTourist.Application.Features.Main.Hotel.Queries.GetHotelAttachmentsByHotelId;

public class GetHotelAttachmentsByHotelIdDto
{
    public int HotelId { get; set; }
    public Guid AttachmentId { get; set; }
    public List<byte[]> Contents { get; set; }
}