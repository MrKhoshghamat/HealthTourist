using AutoMapper;
using HealthTourist.Application.Features.Common.City.Queries.GetCityAttachmentByCityId;
using HealthTourist.Domain.Interface;

namespace HealthTourist.Application.MappingProfiles.Interface;

public class CityAttachmentProfile : Profile
{
    public CityAttachmentProfile()
    {
        CreateMap<CityAttachment, GetCityAttachmentByCityIdDto>()
            .ForMember(dest =>
                dest.CityId, opt =>
                opt.MapFrom(src => src.CityId))
            .ForMember(dest =>
                dest.AttachmentId, opt =>
                opt.MapFrom(src => src.AttachmentId))
            .ForMember(dest =>
                dest.CityName, opt =>
                opt.MapFrom(src => src.City.Name))
            .ForMember(dest =>
                dest.Content, opt =>
                opt.MapFrom(src => src.Attachment.Content)).ReverseMap();
    }
}