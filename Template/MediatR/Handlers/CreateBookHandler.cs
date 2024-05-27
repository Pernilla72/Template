namespace Template.MediatR.Handlers;

//En Handler som heter CreateBookHandler. Den tar in en request från CreateBookCommand och returnerar ett
//new objekt IRequestHandler<CreateBookCommand, av typen Book.
public class CreateBookHandler : IRequestHandler<CreateBookCommand, Book>
{
    private readonly List<Book> _books = new List<Book>();

    public Task<Book> Handle(CreateBookCommand request, CancellationToken cancellationToken)
    {
       var _books = request.Id;

        return Task.FromResult(new Book());
    }
}

