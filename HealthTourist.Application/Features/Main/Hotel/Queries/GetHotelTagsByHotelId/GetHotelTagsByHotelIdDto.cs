namespace HealthTourist.Application.Features.Main.Hotel.Queries.GetHotelTagsByHotelId;

public class GetHotelTagsByHotelIdDto
{
    public int HotelId { get; set; }
    public int TagId { get; set; }
    public string HotelTitle { get; set; }
    public List<string> TagTitles { get; set; }
}