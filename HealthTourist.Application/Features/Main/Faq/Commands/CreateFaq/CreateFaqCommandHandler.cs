using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using MediatR;

namespace HealthTourist.Application.Features.Main.Faq.Commands.CreateFaq;

public class CreateFaqCommandHandler(IFaqRepository faqRepository, IMapper mapper)
    : IRequestHandler<CreateFaqCommand, int>
{
    public async Task<int> Handle(CreateFaqCommand request, CancellationToken cancellationToken)
    {
        var faq = mapper.Map<Domain.Main.Faq>(request);
        await faqRepository.CreateAsync(faq);
        return faq.Id;
    }
}