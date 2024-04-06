using AutoMapper;
using HealthTourist.Application.Features.Main.FaqType.Queries.GetFaqTypeDetails;
using HealthTourist.Application.Features.Main.FaqType.Queries.GetFaqTypes;
using HealthTourist.Domain.Main;

namespace HealthTourist.Application.MappingProfiles.Main;

public class FaqTypeProfile : Profile
{
    public FaqTypeProfile()
    {
        CreateMap<FaqType, GetFaqTypesDto>().ReverseMap();
        CreateMap<FaqType, GetFaqTypeDetailsDto>().ReverseMap();
    }
}