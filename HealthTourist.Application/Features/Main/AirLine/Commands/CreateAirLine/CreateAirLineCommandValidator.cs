using FluentValidation;

namespace HealthTourist.Application.Features.Main.AirLine.Commands.CreateAirLine;

public class CreateAirLineCommandValidator : AbstractValidator<CreateAirLineCommand>
{
    public CreateAirLineCommandValidator()
    {
        RuleFor(a => a.Name)
            .NotNull().WithMessage("")
            .NotEmpty().WithMessage("")
            .MaximumLength(10).WithMessage("");
        
        RuleFor(a => a.Title)
            .NotNull().WithMessage("")
            .NotEmpty().WithMessage("")
            .MaximumLength(10).WithMessage("");
    }
}