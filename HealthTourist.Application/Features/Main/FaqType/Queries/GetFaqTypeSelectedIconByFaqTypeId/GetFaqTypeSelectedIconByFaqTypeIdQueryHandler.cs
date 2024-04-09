using AutoMapper;
using HealthTourist.Application.Contracts.Interface;
using HealthTourist.Common.Exceptions;
using HealthTourist.Domain.Interface;
using MediatR;

namespace HealthTourist.Application.Features.Main.FaqType.Queries.GetFaqTypeSelectedIconByFaqTypeId;

public class GetFaqTypeSelectedIconByFaqTypeIdQueryHandler(
    IFaqTypeAttachmentRepository faqTypeAttachmentRepository,
    IMapper mapper)
    : IRequestHandler<GetFaqTypeSelectedIconByFaqTypeIdQuery, GetFaqTypeSelectedIconByFaqTypeIdDto>
{
    public async Task<GetFaqTypeSelectedIconByFaqTypeIdDto> Handle(GetFaqTypeSelectedIconByFaqTypeIdQuery request,
        CancellationToken cancellationToken)
    {
        if (request == null) throw new BadRequestException("Incoming request is not valid");
        var faqTypeAttachment =
            await faqTypeAttachmentRepository.FindAsync(fta => fta.FaqTypeId == request.FaqTypeId && fta.IsSelected);
        if (faqTypeAttachment == null) throw new NotFoundException(nameof(FaqTypeAttachment), request.FaqTypeId);

        var result = mapper.Map<GetFaqTypeSelectedIconByFaqTypeIdDto>(faqTypeAttachment);

        return result;
    }
}