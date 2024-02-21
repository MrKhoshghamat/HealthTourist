using FluentValidation;
using HealthTourist.Application.Contracts.AboutUsPage;
using HealthTourist.Common.Constants.AboutUs;

namespace HealthTourist.Application.Features.AboutUsPage.Commands.DeleteAboutUs;

public class DeleteAboutUsCommandValidator : AbstractValidator<DeleteAboutUsCommand>
{
    private readonly IAboutUsRepository _aboutUsRepository;
    public DeleteAboutUsCommandValidator(IAboutUsRepository aboutUsRepository)
    {
        RuleFor(x => x.Id)
            .NotNull().WithMessage(AboutUsValidationConstants.NotNullMessage)
            .NotEmpty().WithMessage(AboutUsValidationConstants.NotEmptyMessage);
        var test = AboutUsAlreadyDeleted(new DeleteAboutUsCommand() { Id = 1 }, default);
        RuleFor(x => x)
            .MustAsync(AboutUsAlreadyDeleted)
            .WithMessage(AboutUsValidationConstants.AboutUsAlreadyIsDeletedMessage);
            
        _aboutUsRepository = aboutUsRepository;
    }

    private async Task<bool> AboutUsAlreadyDeleted(DeleteAboutUsCommand command, CancellationToken cancellationToken)
    {
        return await _aboutUsRepository.IsDeletedAsync(command.Id);
    }
}