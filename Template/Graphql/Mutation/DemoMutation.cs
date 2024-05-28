namespace Template.Graphql.Mutation;

[ExtendObjectType("Mutation")]
public class DemoMutation
{
    public async Task<Demo> CreateDemo([Service] ISender mediator, CreateDemoCommand request)
    {
        return await mediator.Send(request);
    }

    public async Task<Demo> DeleteDemo([Service] ISender mediator, int id)
    {
        return await mediator.Send(new DeleteDemoCommand(id));
    }

    public async Task<Demo> UpdateDemo([Service] ISender mediator, UpdateDemoCommand request)
    {
        return await mediator.Send(request);
    }
}





