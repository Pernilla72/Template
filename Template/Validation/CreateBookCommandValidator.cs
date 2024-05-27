namespace Template.Validation;

//Validerar request som kommer in. Du kan sätta regler för varje parameter som finns med i din request.
//Man behöver inte skriva koden någonannanstans, utan MediatR pipline håller koll på vilka parametrar som ska valideras.
// här valideras parametern Id för objektet Book som kommer från CreateBookCommand.
public class CreateBookCommandValidator : AbstractValidator<CreateBookCommand>
{
    public CreateBookCommandValidator()
    {
        RuleFor(x => x.Id)
             .NotEmpty()
             .WithMessage("Id is mandatory");
    }
}
