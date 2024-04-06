using AutoMapper;
using HealthTourist.Application.Features.Main.TravelCost.Queries.GetTravelCostDetails;
using HealthTourist.Application.Features.Main.TravelCost.Queries.GetTravelCosts;
using HealthTourist.Domain.Main;

namespace HealthTourist.Application.MappingProfiles.Main;

public class TravelCostProfile : Profile
{
    public TravelCostProfile()
    {
        CreateMap<TravelCost, GetTravelCostsDto>().ReverseMap();
        CreateMap<TravelCost, GetTravelCostDetailsDto>().ReverseMap();
    }
}