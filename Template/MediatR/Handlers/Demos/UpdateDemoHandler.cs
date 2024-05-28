namespace Template.MediatR.Handlers.Demos;

public class UpdateDemoHandler : IHandlerWrapper<UpdateDemoCommand, Demo>
{
    public Task<Demo> Handle(UpdateDemoCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
