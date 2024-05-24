namespace Template.MediatR.Handlers;

//En hanterare som skapar en ny bok, returnerar svaret till command och skapar en ny bok??
public class CreateBookHandler : IRequestHandler<CreateBookCommand, Book>
{
    private readonly List<Book> _books = new List<Book>();

    public Task<Book> Handle(CreateBookCommand request, CancellationToken cancellationToken)
    {
       var _books = request.Id;

        return Task.FromResult(new Book());
    }
}

