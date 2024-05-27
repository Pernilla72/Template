namespace Template.MediatR.Commands;

//Command fungerar som request objekt, Fyll i vad du vill ha som request och sen returneras ett objekt "Book" via IRequestWrapper från Handler-klassen.
public class UpdateBookCommand : IRequestWrapper<Book>
{
    public required int Id { get; set; }
    public bool IsAvailable { get; set; }
}
