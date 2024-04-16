using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using MediatR;

namespace HealthTourist.Application.Features.Main.Faq.Commands.UpdateFaq;

public class UpdateFaqCommandHandler(IFaqRepository faqRepository, IMapper mapper)
    : IRequestHandler<UpdateFaqCommand, Unit>
{
    public async Task<Unit> Handle(UpdateFaqCommand request, CancellationToken cancellationToken)
    {
        var faq = mapper.Map<Domain.Main.Faq>(request);
        await faqRepository.UpdateAsync(faq);
        return Unit.Value;
    }
}