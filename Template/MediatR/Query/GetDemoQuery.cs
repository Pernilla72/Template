namespace Template.MediatR.Query;

public class GetDemoQuery : IRequestWrapper<Id>
{
    public int Id { get; set; }

    public GetDemoQuery(int id)
    {
        Id = id;
    }
}