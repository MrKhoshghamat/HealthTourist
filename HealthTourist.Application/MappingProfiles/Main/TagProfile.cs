using AutoMapper;
using HealthTourist.Application.Features.Main.Tag.Queries.GetTagDetails;
using HealthTourist.Application.Features.Main.Tag.Queries.GetTags;
using HealthTourist.Domain.Main;

namespace HealthTourist.Application.MappingProfiles.Main;

public class TagProfile : Profile
{
    public TagProfile()
    {
        CreateMap<Tag, GetTagsDto>().ReverseMap();
        CreateMap<Tag, GetTagDetailsDto>().ReverseMap();
    }
}