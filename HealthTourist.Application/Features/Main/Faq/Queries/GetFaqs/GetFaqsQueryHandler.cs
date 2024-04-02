using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using HealthTourist.Common.Exceptions;
using MediatR;

namespace HealthTourist.Application.Features.Main.Faq.Queries.GetFaqs;

public class GetFaqsQueryHandler(IFaqRepository faqRepository, IMapper mapper)
    : IRequestHandler<GetFaqsQuery, List<GetFaqsDto>>
{
    public async Task<List<GetFaqsDto>> Handle(GetFaqsQuery request, CancellationToken cancellationToken)
    {
        if (request == null) throw new BadRequestException("Incoming request is not valid");
        var faqs = await faqRepository.GetAllAsync();
        if (faqs == null) throw new NotFoundException(nameof(List<Domain.Main.Faq>), request);

        var result = mapper.Map<List<GetFaqsDto>>(faqs);

        return result;
    }
}