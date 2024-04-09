using AutoMapper;
using HealthTourist.Application.Features.Main.Hotel.Queries.GetHotelAttachmentByHotelId;
using HealthTourist.Domain.Interface;

namespace HealthTourist.Application.MappingProfiles.Interface;

public class HotelAttachmentProfile : Profile
{
    public HotelAttachmentProfile()
    {
        CreateMap<HotelAttachment, GetHotelAttachmentByHotelIdDto>()
            .ForMember(dest =>
                dest.HotelId, opt =>
                opt.MapFrom(src => src.HotelId))
            .ForMember(dest =>
                dest.AttachmentId, opt =>
                opt.MapFrom(src => src.AttachmentId))
            .ForMember(dest =>
                dest.Content, opt =>
                opt.MapFrom(src => src.Attachment.Content)).ReverseMap();
    }
}