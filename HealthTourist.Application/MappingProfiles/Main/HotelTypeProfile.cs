using AutoMapper;
using HealthTourist.Application.Features.Main.HotelType.Queries.GetHotelTypeDetails;
using HealthTourist.Application.Features.Main.HotelType.Queries.GetHotelTypes;
using HealthTourist.Domain.Main;

namespace HealthTourist.Application.MappingProfiles.Main;

public class HotelTypeProfile : Profile
{
    public HotelTypeProfile()
    {
        CreateMap<HotelType, GetHotelTypesDto>().ReverseMap();
        CreateMap<HotelType, GetHotelTypeDetailsDto>().ReverseMap();
    }
}