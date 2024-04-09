using AutoMapper;
using HealthTourist.Application.Features.Main.TreatmentType.Queries.GetTreatmentTypeIconByTreatmentTypeId;
using HealthTourist.Domain.Interface;

namespace HealthTourist.Application.MappingProfiles.Interface;

public class TreatmentTypeAttachmentProfile : Profile
{
    public TreatmentTypeAttachmentProfile()
    {
        CreateMap<TreatmentTypeAttachment, GetTreatmentTypeIconByTreatmentTypeIdDto>()
            .ForMember(dest =>
                    dest.TreatmentTypeId,
                opt =>
                    opt.MapFrom(src => src.TreatmentTypeId))
            .ForMember(dest =>
                    dest.AttachmentId,
                opt =>
                    opt.MapFrom(src => src.AttachmentId))
            .ForMember(dest =>
                    dest.Content,
                opt =>
                    opt.MapFrom(src => src.Attachment.Content)).ReverseMap();
    }
}