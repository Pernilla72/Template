namespace Template.Validation;

public class CreateBookCommandValidator : AbstractValidator<CreateBookCommand>
{
    public CreateBookCommandValidator()
    {
        RuleFor(x => x.Id)
             .NotEmpty()
             .WithMessage("Id is mandatory");
    }
}
