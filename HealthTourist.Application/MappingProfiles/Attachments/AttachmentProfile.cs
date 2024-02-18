using AutoMapper;
using HealthTourist.Application.Features.Attachments.Commands.CreateAttachment;
using HealthTourist.Application.Features.Attachments.Commands.DeleteAttachment;
using HealthTourist.Application.Features.Attachments.Commands.UpdateAttachment;
using HealthTourist.Application.Features.Attachments.Queries.GetAttachmentDetails;
using HealthTourist.Application.Features.Attachments.Queries.GetAttachments;
using HealthTourist.Domain.Common;

namespace HealthTourist.Application.MappingProfiles.Attachments;

public class AttachmentProfile : Profile
{
    public AttachmentProfile()
    {
        CreateMap<Attachment, GetAttachmentsDto>().ReverseMap();
        CreateMap<Attachment, GetAttachmentDetailsDto>().ReverseMap();

        CreateMap<Attachment, CreateAttachmentCommand>().ReverseMap();
        CreateMap<Attachment, UpdateAttachmentCommand>().ReverseMap();
        CreateMap<Attachment, DeleteAttachmentCommand>().ReverseMap();
    }
}