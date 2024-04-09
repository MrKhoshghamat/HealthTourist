using AutoMapper;
using HealthTourist.Application.Features.Main.Doctor.Queries.GetDoctorAttachmentByDoctorId;
using HealthTourist.Domain.Interface;

namespace HealthTourist.Application.MappingProfiles.Interface;

public class DoctorAttachmentProfile : Profile
{
    public DoctorAttachmentProfile()
    {
        CreateMap<DoctorAttachment, GetDoctorAttachmentByDoctorIdDto>()
            .ForMember(dest =>
                    dest.DoctorId,
                opt =>
                    opt.MapFrom(src => src.DoctorId))
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