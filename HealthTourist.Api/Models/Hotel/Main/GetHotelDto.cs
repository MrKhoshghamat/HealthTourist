using HealthTourist.Api.Models.Hotel.Sub;

namespace HealthTourist.Api.Models.Hotel.Main;

public class GetHotelDto
{
    public List<HotelCityDto> Cities { get; set; }
    public List<HotelCityHotelDto> Hotels { get; set; }
    public List<HotelCitySightseenDto> CitySightseens { get; set; }
}