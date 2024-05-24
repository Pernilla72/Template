namespace Template.MediatR.Query;

public class GetAuthorByIdQuery : IRequestWrapper<Author>
{
    public int Id { get; set; }

    public GetAuthorByIdQuery(int id)
    {
        Id = id;
    }
}


