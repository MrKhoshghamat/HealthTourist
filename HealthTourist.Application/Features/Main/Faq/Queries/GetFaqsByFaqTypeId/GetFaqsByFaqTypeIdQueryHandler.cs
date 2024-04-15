using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using HealthTourist.Common.Exceptions;
using MediatR;

namespace HealthTourist.Application.Features.Main.Faq.Queries.GetFaqsByFaqTypeId;

public class GetFaqsByFaqTypeIdQueryHandler(IFaqRepository faqRepository, IMapper mapper)
    : IRequestHandler<GetFaqsByFaqTypeIdQuery, List<GetFaqsByFaqTypeIdDto>>
{
    public async Task<List<GetFaqsByFaqTypeIdDto>> Handle(GetFaqsByFaqTypeIdQuery request,
        CancellationToken cancellationToken)
    {
        if (request == null) throw new BadRequestException("Incoming request is not valid");
        var faqs = await faqRepository.GetAllAsync(f => f.FaqTypeId == request.FaqTypeId);
        if (faqs == null) throw new NotFoundException(nameof(List<Domain.Main.Faq>), request.FaqTypeId);

        var result = mapper.Map<List<GetFaqsByFaqTypeIdDto>>(faqs);
        return result;
    }
}