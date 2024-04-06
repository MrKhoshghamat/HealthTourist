using AutoMapper;
using HealthTourist.Application.Features.Main.HotelRank.Queries.GetHotelRankDetails;
using HealthTourist.Application.Features.Main.HotelRank.Queries.GetHotelRanks;
using HealthTourist.Domain.Main;

namespace HealthTourist.Application.MappingProfiles.Main;

public class HotelRankProfile : Profile
{
    public HotelRankProfile()
    {
        CreateMap<HotelRank, GetHotelRanksDto>().ReverseMap();
        CreateMap<HotelRank, GetHotelRankDetailsDto>().ReverseMap();
    }
}