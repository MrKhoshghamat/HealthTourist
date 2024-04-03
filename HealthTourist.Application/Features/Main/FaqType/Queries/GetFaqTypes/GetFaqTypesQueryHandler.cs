using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using HealthTourist.Common.Exceptions;
using MediatR;

namespace HealthTourist.Application.Features.Main.FaqType.Queries.GetFaqTypes;

public class GetFaqTypesQueryHandler(IFaqTypeRepository faqTypeRepository, IMapper mapper)
    : IRequestHandler<GetFaqTypesQuery, List<GetFaqTypesDto>>
{
    public async Task<List<GetFaqTypesDto>> Handle(GetFaqTypesQuery request, CancellationToken cancellationToken)
    {
        if (request == null) throw new BadRequestException("Incoming request is not valid");
        var faqTypes = await faqTypeRepository.GetAllAsync();
        if (faqTypes == null) throw new NotFoundException(nameof(List<Domain.Main.FaqType>), request);

        var result = mapper.Map<List<GetFaqTypesDto>>(faqTypes);
        return result;
    }
}