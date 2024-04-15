using HealthTourist.Application.Features.Interface.SightseenCategory.Queries.GetSightseenCategories;
using HealthTourist.Application.Features.Main.Sightseen.Queries.GetSightseensByCityName;

namespace HealthTourist.Api.Models.Hotel.Sub;

public class HotelCitySightseenDto
{
    public List<string> SightseenCategories { get; set; }
    public List<HotelCitySightseenPictureDto> Pictures { get; set; }
}