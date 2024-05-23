namespace Template.MediatR.Commands;

public class DeleteBookCommand : IRequestWrapper<Book>
{
    //private object id;
    public int Id { get; }

    public DeleteBookCommand(int id)
    {
        Id = id;
    }
}

