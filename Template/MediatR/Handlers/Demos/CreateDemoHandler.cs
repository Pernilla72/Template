namespace Template.MediatR.Handlers.Demos;

public class CreateDemoHandler : IHandlerWrapper<CreateDemoCommand, Demo>
{
    public Task<Demo> Handle(CreateDemoCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
