namespace Template.Graphql.Query;

[ExtendObjectType("Query")]
public class GetAuthorQuery
{
    public async Task<Author> GetAuthor([Service] ISender mediator, int Id)
    {
        return await mediator.Send(new GetAuthorByIdQuery(Id));
    }
}
