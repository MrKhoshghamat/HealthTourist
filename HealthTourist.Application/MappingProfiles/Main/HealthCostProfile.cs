using AutoMapper;
using HealthTourist.Application.Features.Main.HealthCost.Queries.GetHealthCostDetails;
using HealthTourist.Application.Features.Main.HealthCost.Queries.GetHealthCosts;
using HealthTourist.Domain.Main;

namespace HealthTourist.Application.MappingProfiles.Main;

public class HealthCostProfile : Profile
{
    public HealthCostProfile()
    {
        CreateMap<HealthCost, GetHealthCostsDto>().ReverseMap();
        CreateMap<HealthCost, GetHealthCostDetailsDto>().ReverseMap();
    }
}