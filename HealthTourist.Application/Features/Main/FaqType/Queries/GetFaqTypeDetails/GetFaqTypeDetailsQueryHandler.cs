using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using HealthTourist.Common.Exceptions;
using MediatR;

namespace HealthTourist.Application.Features.Main.FaqType.Queries.GetFaqTypeDetails;

public class GetFaqTypeDetailsQueryHandler(IFaqTypeRepository faqTypeRepository, IMapper mapper)
    : IRequestHandler<GetFaqTypeDetailsQuery, GetFaqTypeDetailsDto>
{
    public async Task<GetFaqTypeDetailsDto> Handle(GetFaqTypeDetailsQuery request, CancellationToken cancellationToken)
    {
        if (request == null) throw new BadRequestException("Incoming request is not valid");
        var faqTypeDetails = await faqTypeRepository.FindAsync(request.Id);
        if (faqTypeDetails == null) throw new NotFoundException(nameof(Domain.Main.FaqType), request.Id);

        var result = mapper.Map<GetFaqTypeDetailsDto>(faqTypeDetails);
        return result;
    }
}