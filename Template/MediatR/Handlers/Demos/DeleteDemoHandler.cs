namespace Template.MediatR.Handlers.Demos;

public class DeleteDemoHandler : IHandlerWrapper<DeleteDemoCommand, Demo>
{
    public Task<Demo> Handle(DeleteDemoCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
