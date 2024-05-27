namespace Template.MediatR.Commands;

//Command fungerar som request objekt, Fyll i vad du vill ha som request och sen returneras ett objekt "Book" via IRequestWrapper från Handler-klassen.
public class DeleteBookCommand : IRequestWrapper<Book>
{
    //private object id;
    public int Id { get; }

    public DeleteBookCommand(int id)
    {
        Id = id;
    }
}

