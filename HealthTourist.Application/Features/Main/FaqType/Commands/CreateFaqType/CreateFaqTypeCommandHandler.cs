using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using MediatR;

namespace HealthTourist.Application.Features.Main.FaqType.Commands.CreateFaqType;

public class CreateFaqTypeCommandHandler(IFaqTypeRepository faqTypeRepository, IMapper mapper)
    : IRequestHandler<CreateFaqTypeCommand, int>
{
    public async Task<int> Handle(CreateFaqTypeCommand request, CancellationToken cancellationToken)
    {
        var faqType = mapper.Map<Domain.Main.FaqType>(request);
        await faqTypeRepository.CreateAsync(faqType);
        return faqType.Id;
    }
}