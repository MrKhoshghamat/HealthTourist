using AutoMapper;
using HealthTourist.Application.Features.Main.Travel.Queries.GetTravelDetails;
using HealthTourist.Application.Features.Main.Travel.Queries.GetTravels;
using HealthTourist.Domain.Main;

namespace HealthTourist.Application.MappingProfiles.Main;

public class TravelProfile : Profile
{
    public TravelProfile()
    {
        CreateMap<Travel, GetTravelsDto>().ReverseMap();
        CreateMap<Travel, GetTravelDetailsDto>().ReverseMap();
    }
}