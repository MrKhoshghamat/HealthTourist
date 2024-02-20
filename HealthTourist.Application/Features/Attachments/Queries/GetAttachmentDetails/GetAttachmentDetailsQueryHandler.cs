using System.Net.Mail;
using AutoMapper;
using HealthTourist.Application.Contracts.Attachments;
using HealthTourist.Common.Exceptions;
using MediatR;

namespace HealthTourist.Application.Features.Attachments.Queries.GetAttachmentDetails;

public class GetAttachmentDetailsQueryHandler(IAttachmentRepository attachmentRepository, IMapper mapper)
    : IRequestHandler<GetAttachmentDetailsQuery, GetAttachmentDetailsDto>
{
    #region Handler

    public async Task<GetAttachmentDetailsDto> Handle(GetAttachmentDetailsQuery request,
        CancellationToken cancellationToken)
    {
        // Fetch Attachment Records from database
        var attachmentDetails = await attachmentRepository.FindAsync(request.Id);

        // Check fetched records for null
        if (attachmentDetails == null) throw new NotFoundException(nameof(Attachment), request.Id);

        // Map Attachment Records to list of required result
        var result = mapper.Map<GetAttachmentDetailsDto>(attachmentDetails);

        // Return result
        return result;
    }

    #endregion
}