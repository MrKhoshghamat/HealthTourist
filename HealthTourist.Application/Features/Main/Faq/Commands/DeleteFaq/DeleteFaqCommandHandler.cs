using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using MediatR;

namespace HealthTourist.Application.Features.Main.Faq.Commands.DeleteFaq;

public class DeleteFaqCommandHandler(IFaqRepository faqRepository, IMapper mapper)
    : IRequestHandler<DeleteFaqCommand, Unit>
{
    public async Task<Unit> Handle(DeleteFaqCommand request, CancellationToken cancellationToken)
    {
        var faq = mapper.Map<Domain.Main.Faq>(request);
        await faqRepository.DeleteAsync(faq);
        return Unit.Value;
    }
}