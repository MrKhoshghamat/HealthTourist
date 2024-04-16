using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using MediatR;

namespace HealthTourist.Application.Features.Main.FaqType.Commands.UpdateFaqType;

public class UpdateFaqTypeCommandValidator(IFaqTypeRepository faqTypeRepository, IMapper mapper)
    : IRequestHandler<UpdateFaqTypeCommand, Unit>
{
    public async Task<Unit> Handle(UpdateFaqTypeCommand request, CancellationToken cancellationToken)
    {
        var faqType = mapper.Map<Domain.Main.FaqType>(request);
        await faqTypeRepository.UpdateAsync(faqType);
        return Unit.Value;
    }
}