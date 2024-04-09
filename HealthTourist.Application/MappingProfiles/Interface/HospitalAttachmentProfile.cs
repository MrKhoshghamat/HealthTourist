using AutoMapper;
using HealthTourist.Application.Features.Main.Hospital.Queries.GetHospitalAttachmentByHospitalId;
using HealthTourist.Domain.Interface;

namespace HealthTourist.Application.MappingProfiles.Interface;

public class HospitalAttachmentProfile : Profile
{
    public HospitalAttachmentProfile()
    {
        CreateMap<HospitalAttachment, GetHospitalAttachmentByHospitalIdDto>()
            .ForMember(dest =>
                dest.HospitalId, opt =>
                opt.MapFrom(src => src.HospitalId))
            .ForMember(dest =>
                dest.AttachmentId, opt =>
                opt.MapFrom(src => src.AttachmentId))
            .ForMember(dest =>
                dest.Content, opt =>
                opt.MapFrom(src => src.Attachment.Content)).ReverseMap();
    }
}