using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using MediatR;

namespace HealthTourist.Application.Features.Main.FaqType.Commands.DeleteFaqType;

public class DeleteFaqTypeCommandHandler(IFaqTypeRepository faqTypeRepository, IMapper mapper)
    : IRequestHandler<DeleteFaqTypeCommand, Unit>
{
    public async Task<Unit> Handle(DeleteFaqTypeCommand request, CancellationToken cancellationToken)
    {
        var faqType = mapper.Map<Domain.Main.FaqType>(request);
        await faqTypeRepository.DeleteAsync(faqType);
        return Unit.Value;
    }
}