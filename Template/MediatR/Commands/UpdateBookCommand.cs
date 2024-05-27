namespace Template.MediatR.Commands;

//Command fungerar som request objekt, Fyll i vad du vill ha som request och sen vad responsen ska vara, i detta fallet en typ av Book-objekt
public class UpdateBookCommand : IRequestWrapper<Book>
{
    public required int Id { get; set; }
    public bool IsAvailable { get; set; }
}
