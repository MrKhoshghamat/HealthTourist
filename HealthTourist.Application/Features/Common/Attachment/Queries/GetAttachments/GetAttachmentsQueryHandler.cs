using AutoMapper;
using HealthTourist.Application.Contracts.Common;
using HealthTourist.Common.Exceptions;
using MediatR;

namespace HealthTourist.Application.Features.Common.Attachment.Queries.GetAttachments;

public class GetAttachmentsQueryHandler(IAttachmentRepository attachmentRepository, IMapper mapper)
: IRequestHandler<GetAttachmentsQuery, List<GetAttachmentsDto>>
{
    public async Task<List<GetAttachmentsDto>> Handle(GetAttachmentsQuery request, CancellationToken cancellationToken)
    {
        if (request == null) throw new BadRequestException("Incoming request is not valid");
        var attachments = await attachmentRepository.GetAllAsync();
        if (attachments == null) throw new NotFoundException(nameof(List<Domain.Common.Attachment>), request);

        var result = mapper.Map<List<GetAttachmentsDto>>(attachments);
        return result;
    }
}