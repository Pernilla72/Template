namespace Template.Graphql.Query;

[ExtendObjectType("Query")]
public class DemoQuery
{
    public async Task<Demo> GetDemo([Service] ISender mediator, int id)
    {
        return await mediator.Send(new GetDemoQuery(id));
    }
}
