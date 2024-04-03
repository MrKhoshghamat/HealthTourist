using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using HealthTourist.Common.Exceptions;
using MediatR;

namespace HealthTourist.Application.Features.Main.Faq.Queries.GetFaqDetails;

public class GetFaqDetailsQueryHandler(IFaqRepository faqRepository, IMapper mapper)
: IRequestHandler<GetFaqDetailsQuery, GetFaqDetailsDto>
{
    public async Task<GetFaqDetailsDto> Handle(GetFaqDetailsQuery request, CancellationToken cancellationToken)
    {
        if (request == null) throw new BadRequestException("Incoming request is not valid");
        var faqDetails = await faqRepository.FindAsync(request.Id);
        if (faqDetails == null) throw new NotFoundException(nameof(Domain.Main.Faq), request.Id);

        var result = mapper.Map<GetFaqDetailsDto>(faqDetails);
        return result;
    }
}