namespace Template.MediatR.Query;

public class GetDemoQuery : IRequestWrapper<Demo>
{
    public int Id { get; set; }

    public GetDemoQuery(int id)
    {
        Id = id;
    }
}