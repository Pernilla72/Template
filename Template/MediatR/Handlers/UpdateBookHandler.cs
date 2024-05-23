﻿namespace Template.MediatR.Handlers;

public class UpdateBookHandler : IRequestHandler<UpdateBookCommand, Book>
{
    private readonly List<Book> _booksOne = new List<Book>
        {
            new Book { Id = 1, IsAvailable = true},
            new Book { Id = 2, IsAvailable = false},
            new Book { Id = 3, IsAvailable= false},
            // Add more fake products as needed
        };
    public Task<Book> Handle(UpdateBookCommand request, CancellationToken cancellationToken)
    {
        var book = _booksOne.FirstOrDefault(b => b.Id == request.Id);
        if (_booksOne == null) 
        { 
        throw new Exception("Book is not found");
        }

        book.IsAvailable = request.IsAvailable;
        return Task.FromResult(book);
    }
}
