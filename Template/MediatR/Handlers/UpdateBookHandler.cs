namespace Template.MediatR.Handlers;


//En Handler som heter UpdateBookHandler.Den tar in en request från UpdateBookCommand och returnerar ett
//det id som man valt att radera, i detta exempel är det id 3.

public class UpdateBookHandler : IRequestHandler<UpdateBookCommand, Book>
{
    private readonly List<Book> _booksOne = new List<Book>
        {
            new Book { Id = 1, IsAvailable = true},
            new Book { Id = 2, IsAvailable = false},
            new Book { Id = 3, IsAvailable= false},
            //// Lägg till fler fake Book's om det behövs
        };
    public Task<Book> Handle(UpdateBookCommand request, CancellationToken cancellationToken)
    {
        var book = _booksOne.FirstOrDefault(b => b.Id == request.Id);
        if (book == null) 
        { 
            throw new Exception("Book is not found");
        }

        book.IsAvailable = request.IsAvailable;
        return Task.FromResult(book);
    }
}

