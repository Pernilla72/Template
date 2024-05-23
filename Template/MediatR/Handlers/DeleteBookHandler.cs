namespace Template.MediatR.Handlers;

public class DeleteBookHandler : IRequestHandler<DeleteBookCommand, Book>
{
    private readonly List<Book> _booksOne;

    public DeleteBookHandler()
    {
        _booksOne = new List<Book>
        {
                new Book { Id = 1, Title = "Den femte årstiden"},
                new Book { Id = 2, Title = "Den gamle och havet"},
                new Book { Id = 3, Title = "Pippi Långstrump"},
            // Lägg till fler böcker om det behövs
        };
    }

    public Task<Book> Handle(DeleteBookCommand request, CancellationToken cancellationToken)
    {
        var book = _booksOne.FirstOrDefault(p => p.Id == request.Id);
        if (book == null)
        {
            return Task.FromResult<Book>(null);
        }

        _booksOne.Remove(book);
        return Task.FromResult(book);
    }
}

