﻿namespace Template.MediatR.Handlers;

public class GetBookHandler : IRequestHandler<GetBookQuery, Book>
{
    private readonly List<Book> _booksOne = new List<Book>
        {
            new Book { Id = 1, Title = "Den femte årstiden"},
            new Book { Id = 2, Title = "Den gamle och havet"},
            new Book { Id = 3, Title = "Pippi Långstrump"},
            // Add more fake products as needed
        };

    public Task<Book> Handle(GetBookQuery request, CancellationToken cancellationToken)
    {
        Book book = GetBook(request);
        return Task.FromResult(book);
    }

   public Book GetBook(GetBookQuery request)
    {
        return _booksOne.FirstOrDefault(p => p.Id == request.Id);
    }
}


