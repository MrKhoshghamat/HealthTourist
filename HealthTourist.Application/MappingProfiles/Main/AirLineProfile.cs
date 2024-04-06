using AutoMapper;
using HealthTourist.Application.Features.Main.AirLine.Queries.GetAirLineDetails;
using HealthTourist.Application.Features.Main.AirLine.Queries.GetAirLines;
using HealthTourist.Domain.Main;

namespace HealthTourist.Application.MappingProfiles.Main;

public class AirLineProfile : Profile
{
    public AirLineProfile()
    {
        CreateMap<AirLine, GetAirLinesDto>().ReverseMap();
        CreateMap<AirLine, GetAirLineDetailsDto>().ReverseMap();
    }
}