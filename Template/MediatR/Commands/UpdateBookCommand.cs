namespace Template.MediatR.Commands;

public class UpdateBookCommand : IRequestWrapper<Book>
{
    public int Id { get; set; }
    public bool IsAvailable { get; set; }
    public UpdateBookCommand(int Id, bool isAvailable)
    {
        IsAvailable = isAvailable;
    }

    public UpdateBookCommand(int id)
    {
        Id = id;
    }
}
