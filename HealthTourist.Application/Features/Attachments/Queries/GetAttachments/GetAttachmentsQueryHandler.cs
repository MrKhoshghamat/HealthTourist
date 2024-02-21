using System.Net.Mail;
using AutoMapper;
using HealthTourist.Application.Contracts.Attachments;
using HealthTourist.Common.Exceptions;
using MediatR;

namespace HealthTourist.Application.Features.Attachments.Queries.GetAttachments;

public class GetAttachmentsQueryHandler(IAttachmentRepository attachmentRepository, IMapper mapper)
    : IRequestHandler<GetAttachmentsQuery, List<GetAttachmentsDto>>
{
    #region Handler

    public async Task<List<GetAttachmentsDto>> Handle(GetAttachmentsQuery request, CancellationToken cancellationToken)
    {
        // Fetch Attachment Records from database
        var attachments = await attachmentRepository.GetAllAsync(x => !x.IsDeleted);

        // Check fetched records for null
        if (attachments == null) throw new NotFoundException(nameof(List<Attachment>), request);

        // Map Attachment Records to list of required result
        var result = mapper.Map<List<GetAttachmentsDto>>(attachments);

        // Return result
        return result;
    }

    #endregion
}