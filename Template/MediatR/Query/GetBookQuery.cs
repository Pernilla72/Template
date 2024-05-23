namespace Template.MediatR.Query;

public class GetBookQuery : IRequestWrapper<Book>
{
    public int Id { get; set; }

    public GetBookQuery(int id)
    {
        Id = id;
    }
}
