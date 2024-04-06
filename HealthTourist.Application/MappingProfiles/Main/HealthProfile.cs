using AutoMapper;
using HealthTourist.Application.Features.Main.Health.Queries.GetHealthDetails;
using HealthTourist.Application.Features.Main.Health.Queries.GetHealths;
using HealthTourist.Domain.Main;

namespace HealthTourist.Application.MappingProfiles.Main;

public class HealthProfile : Profile
{
    public HealthProfile()
    {
        CreateMap<Health, GetHealthsDto>().ReverseMap();
        CreateMap<Health, GetHealthDetailsDto>().ReverseMap();
    }
}