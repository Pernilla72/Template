﻿namespace Template.MediatR.Handlers;

//Klassen "GetAuthorByIDHandler" som ärver egenskapoer av IRequestHandler-klassen, 
//och den tar en request från GetAuthorById och returnerar en Author
public class GetAuthorByIdHandler : IRequestHandler<GetAuthorByIdQuery, Author>
{
    private readonly List<Author> _authors = new List<Author>
        {
            new Author { Id = 1, Name = "Måns Kallentoft", Age = 45, Nationality = "Swedish" },
            new Author { Id = 2, Name = "Ernest Hemingway", Age = 102, Nationality = "American" },
            new Author { Id = 3, Name = "Astrid Lindgren", Age = 99, Nationality = "Swedish" },
            // Lägg till fler fake authors om behövs
        };

    public Task<Author> Handle(GetAuthorByIdQuery request, CancellationToken cancellationToken)
    {
        //Hämtar författare
        Author author = GetAuthor(request);
        return Task.FromResult(author);
    }

    public Author GetAuthor(GetAuthorByIdQuery request)
    {
        //Hämtar första författaren som matchar
        return _authors.FirstOrDefault(a => a.Id == request.Id);
    }
}

