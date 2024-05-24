namespace Template.Graphql.Query;

[ExtendObjectType("Query")]
public class BookQuery 
{
    public async Task<Book> GetBook([Service] ISender mediator, int id)
    {
        return await mediator.Send(new GetBookQuery(id));
    }
}

