using Microsoft.AspNetCore.Mvc;

namespace HealthTourist.Api.Models.Hotel.Sub;

public class HotelCityDto
{
    public string Name { get; set; }
    public string Title { get; set; }
    public FileContentResult picture { get; set; }
}