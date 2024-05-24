namespace Template.MediatR.Commands;

public class UpdateBookCommand : IRequestWrapper<Book>
{
    public required int Id { get; set; }
    public bool IsAvailable { get; set; }
}
