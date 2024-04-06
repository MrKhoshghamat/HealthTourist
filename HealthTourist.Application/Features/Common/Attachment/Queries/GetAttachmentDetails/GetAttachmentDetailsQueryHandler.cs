using AutoMapper;
using HealthTourist.Application.Contracts.Common;
using HealthTourist.Common.Exceptions;
using MediatR;

namespace HealthTourist.Application.Features.Common.Attachment.Queries.GetAttachmentDetails;

public class GetAttachmentDetailsQueryHandler(IAttachmentRepository attachmentRepository, IMapper mapper)
    : IRequestHandler<GetAttachmentDetailsQuery, GetAttachmentDetailsDto>
{
    public async Task<GetAttachmentDetailsDto> Handle(GetAttachmentDetailsQuery request,
        CancellationToken cancellationToken)
    {
        if (request == null) throw new BadRequestException("Incoming request is not valid");
        var attachment = await attachmentRepository.FindAsync(request.Id);
        if (attachment == null) throw new NotFoundException(nameof(Domain.Common.Attachment), request.Id);

        var result = mapper.Map<GetAttachmentDetailsDto>(attachment);
        return result;
    }
}