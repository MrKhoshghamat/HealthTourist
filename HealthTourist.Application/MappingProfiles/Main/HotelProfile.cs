using AutoMapper;
using HealthTourist.Application.Features.Main.Hotel.Queries.GetHotelDetails;
using HealthTourist.Application.Features.Main.Hotel.Queries.GetHotels;
using HealthTourist.Domain.Main;

namespace HealthTourist.Application.MappingProfiles.Main;

public class HotelProfile : Profile
{
    public HotelProfile()
    {
        CreateMap<Hotel, GetHotelsDto>().ReverseMap();
        CreateMap<Hotel, GetHotelDetailsDto>().ReverseMap();
    }
}