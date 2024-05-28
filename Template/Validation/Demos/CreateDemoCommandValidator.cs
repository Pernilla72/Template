namespace Template.Validation.Demos;

public class CreateDemoCommandValidator : AbstractValidator<CreateDemoCommand>
{
    public CreateDemoCommandValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty()
            .WithMessage("id is mandatory");
    }
}
