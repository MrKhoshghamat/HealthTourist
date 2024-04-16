using Microsoft.AspNetCore.Mvc;

namespace HealthTourist.Api.Models.Hotel.Sub;

public class HotelCitySightseenPictureDto
{
    public string Title { get; set; }
    public FileContentResult Picture { get; set; }
}