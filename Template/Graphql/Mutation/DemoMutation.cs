namespace Template.Graphql.Mutation
{
    [ExtendObjectType("Mutation")]
    public class DemoMutation
    {
        public async Task<Id> CreateDemo([Service] ISender mediator, CreateDemoCommand request)
        {
            return await mediator.Send(request);
        }

        public async Task<Id> DeleteDemo([Service] ISender mediator, int id)
        {
            return await mediator.Send(new DeleteDemoCommand(id));
        }

        public async Task<Id> UpdateDemo([Service] ISender mediator, UpdateDemoCommand request)
        {
            return await mediator.Send(request);
        }
    }
}





