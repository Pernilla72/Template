namespace Template.MediatR.Handlers;

public class GetBookHandler : IRequestHandler<GetBookQuery, Book>
{
    private readonly List<Book> _booksOne = new List<Book>
        {
            new Book { Id = 1, Title = "Den femte årstiden"},
            new Book { Id = 2, Title = "Den gamle och havet"},
            new Book { Id = 3, Title = "Pippi Långstrump"},
            // Lägg till fler fake Book's om det behövs
        };

    public Task<Book> Handle(GetBookQuery request, CancellationToken cancellationToken)
    {
        //Hämtar böcker
        Book book = GetBook(request);
        return Task.FromResult(book);
    }

    public Book GetBook(GetBookQuery request)
    {
        //Hämtar första boken som matchar
        return _booksOne.FirstOrDefault(p => p.Id == request.Id);
    }
}



