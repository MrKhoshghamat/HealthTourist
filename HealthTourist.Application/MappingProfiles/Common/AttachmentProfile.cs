using AutoMapper;
using HealthTourist.Application.Features.Common.Attachment.Queries.GetAttachmentDetails;
using HealthTourist.Application.Features.Common.Attachment.Queries.GetAttachments;
using HealthTourist.Domain.Common;

namespace HealthTourist.Application.MappingProfiles.Common;

public class AttachmentProfile : Profile
{
    public AttachmentProfile()
    {
        CreateMap<Attachment, GetAttachmentsDto>().ReverseMap();
        CreateMap<Attachment, GetAttachmentDetailsDto>().ReverseMap();
    }
}