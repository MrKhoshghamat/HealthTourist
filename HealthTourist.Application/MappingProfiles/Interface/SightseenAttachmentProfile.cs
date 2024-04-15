using AutoMapper;
using HealthTourist.Application.Features.Main.Sightseen.Queries.GetSightseenAttachmentsByCityName;
using HealthTourist.Domain.Interface;

namespace HealthTourist.Application.MappingProfiles.Interface;

public class SightseenAttachmentProfile : Profile
{
    public SightseenAttachmentProfile()
    {
        CreateMap<SightseenAttachment, GetSightseenAttachmentsByCityNameDto>()
            .ForMember(dest =>
                dest.Title, opt =>
                opt.MapFrom(src => src.Sightseen.Title))
            .ForMember(dest =>
                dest.Content, opt =>
                opt.MapFrom(src => src.Attachment.Content)).ReverseMap();
    }
}