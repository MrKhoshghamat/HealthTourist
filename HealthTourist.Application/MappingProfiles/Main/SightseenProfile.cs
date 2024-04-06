using AutoMapper;
using HealthTourist.Application.Features.Main.Sightseen.Queries.GetSightseenDetails;
using HealthTourist.Application.Features.Main.Sightseen.Queries.GetSightseens;
using HealthTourist.Domain.Main;

namespace HealthTourist.Application.MappingProfiles.Main;

public class SightseenProfile : Profile
{
    public SightseenProfile()
    {
        CreateMap<Tag, GetSightseensDto>().ReverseMap();
        CreateMap<Tag, GetSightseenDetailsDto>().ReverseMap();
    }
}