﻿namespace Template.MediatR.Commands;

//Command fungerar som request objekt, Fyll i vad du vill ha som request och sen returneras ett objekt "Book" via IRequestWrapper från Handler-klassen.
public class CreateBookCommand : IRequestWrapper<Book>
{
    public required int Id { get; set; }
    public string? Title { get; set; }

    public Author? Author { get; set; }

    public int NumberOfPages { get; set; }

    public bool IsAvailable { get; set; }

    public string? Genre { get; set; }

    public CreateBookCommand(int id)
    {
        Id = id;
        Title = Title;
        Author = Author;
        NumberOfPages = NumberOfPages;
        IsAvailable = true;
        Genre = Genre;
    }
}