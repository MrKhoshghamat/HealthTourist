using AutoMapper;
using HealthTourist.Application.Features.AboutUsAttachments.Commands.CreateAboutUsAttachment;
using HealthTourist.Application.Features.AboutUsAttachments.Commands.DeleteAboutUsAttachment;
using HealthTourist.Application.Features.AboutUsAttachments.Commands.UpdateAboutUsAttachment;
using HealthTourist.Application.Features.AboutUsAttachments.Queries.GetAboutUsAttachmentDetails;
using HealthTourist.Application.Features.AboutUsAttachments.Queries.GetAboutUsAttachments;
using HealthTourist.Domain.AboutUsPage;

namespace HealthTourist.Application.MappingProfiles.AboutUsAttachments;

public class AboutUsAttachmentProfile : Profile
{
    public AboutUsAttachmentProfile()
    {
        CreateMap<AboutUsAttachment, GetAboutUsAttachmentsDto>().ReverseMap();
        CreateMap<AboutUsAttachment, GetAboutUsAttachmentDetailsDto>().ReverseMap();

        CreateMap<AboutUsAttachment, CreateAboutUsAttachmentCommand>().ReverseMap();
        CreateMap<AboutUsAttachment, UpdateAboutUsAttachmentCommand>().ReverseMap();
        CreateMap<AboutUsAttachment, DeleteAboutUsAttachmentCommand>().ReverseMap();
    }
}