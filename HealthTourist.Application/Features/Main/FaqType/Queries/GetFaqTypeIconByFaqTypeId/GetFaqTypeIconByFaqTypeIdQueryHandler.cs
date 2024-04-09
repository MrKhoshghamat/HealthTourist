using AutoMapper;
using HealthTourist.Application.Contracts.Interface;
using HealthTourist.Common.Exceptions;
using HealthTourist.Domain.Interface;
using MediatR;

namespace HealthTourist.Application.Features.Main.FaqType.Queries.GetFaqTypeIconByFaqTypeId;

public class GetFaqTypeIconByFaqTypeIdQueryHandler(
    IFaqTypeAttachmentRepository faqTypeAttachmentRepository,
    IMapper mapper)
    : IRequestHandler<GetFaqTypeIconByFaqTypeIdQuery, GetFaqTypeIconByFaqTypeIdDto>
{
    public async Task<GetFaqTypeIconByFaqTypeIdDto> Handle(GetFaqTypeIconByFaqTypeIdQuery request,
        CancellationToken cancellationToken)
    {
        if (request == null) throw new BadRequestException("Incoming request is not valid");
        var faqTypeAttachment = await faqTypeAttachmentRepository.FindAsync(fta => fta.FaqTypeId == request.FaqTypeId);
        if (faqTypeAttachment == null) throw new NotFoundException(nameof(FaqTypeAttachment), request.FaqTypeId);

        var result = mapper.Map<GetFaqTypeIconByFaqTypeIdDto>(faqTypeAttachment);

        return result;
    }
}