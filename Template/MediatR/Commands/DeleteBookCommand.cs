namespace Template.MediatR.Commands;

//Command fungerar som request objekt, Fyll i vad du vill ha som request och sen vad responsen ska vara, i detta fallet en typ av Book-objekt
public class DeleteBookCommand : IRequestWrapper<Book>
{
    //private object id;
    public int Id { get; }

    public DeleteBookCommand(int id)
    {
        Id = id;
    }
}

