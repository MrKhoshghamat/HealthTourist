namespace HealthTourist.Api.Models.Hotel.Sub;

public class HotelCityHotelDto
{
    public string Name { get; set; }
    public string Title { get; set; }
    public string HotelType { get; set; }
    public string HotelRank { get; set; }
    public string Description { get; set; }
    public List<string> Tags { get; set; }
    public List<byte[]> Pictures { get; set; }
}