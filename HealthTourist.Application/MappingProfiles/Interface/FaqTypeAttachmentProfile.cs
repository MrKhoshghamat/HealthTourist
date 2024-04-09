using AutoMapper;
using HealthTourist.Application.Features.Main.FaqType.Queries.GetFaqTypeIconByFaqTypeId;
using HealthTourist.Application.Features.Main.FaqType.Queries.GetFaqTypeSelectedIconByFaqTypeId;
using HealthTourist.Domain.Interface;

namespace HealthTourist.Application.MappingProfiles.Interface;

public class FaqTypeAttachmentProfile : Profile
{
    public FaqTypeAttachmentProfile()
    {
        CreateMap<FaqTypeAttachment, GetFaqTypeIconByFaqTypeIdDto>()
            .ForMember(dest =>
                    dest.FaqTypeId,
                opt =>
                    opt.MapFrom(src => src.FaqTypeId))
            .ForMember(dest =>
                    dest.AttachmentId,
                opt =>
                    opt.MapFrom(src => src.AttachmentId))
            .ForMember(dest =>
                    dest.Content,
                opt =>
                    opt.MapFrom(src => src.Attachment.Content))
            .ForMember(dest =>
                    dest.IsSelected,
                opt =>
                    opt.MapFrom(src => src.IsSelected)).ReverseMap();

        CreateMap<FaqTypeAttachment, GetFaqTypeSelectedIconByFaqTypeIdDto>()
            .ForMember(dest =>
                    dest.FaqTypeId,
                opt =>
                    opt.MapFrom(src => src.FaqTypeId))
            .ForMember(dest =>
                    dest.AttachmentId,
                opt =>
                    opt.MapFrom(src => src.AttachmentId))
            .ForMember(dest =>
                    dest.Content,
                opt =>
                    opt.MapFrom(src => src.Attachment.Content))
            .ForMember(dest =>
                    dest.IsSelected,
                opt =>
                    opt.MapFrom(src => src.IsSelected)).ReverseMap();
    }
}