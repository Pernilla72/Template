namespace Template.Graphql.Mutation;

[ExtendObjectType("Mutation")]
public class BookMutation
{
    public async Task<Book> CreateBook([Service] ISender mediator, CreateBookCommand request)
    {
        return await mediator.Send(request);
    }

    //public async Task<Book> CreateBookTest([Service] ISender mediator, int id)
    //{
    //    return await mediator.Send(new CreateBookCommand(id));
    //}

    public async Task<Book> DeleteBook([Service] ISender mediator, int id)
    {
        return await mediator.Send(new DeleteBookCommand(id));
    }

    public async Task<Book> UpdateBook([Service] ISender mediator, UpdateBookCommand request)
    {
        return await mediator.Send(request);
    }
}


