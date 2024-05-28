namespace Template.MediatR.Commands.Demos;

public class DeleteDemoCommand : IRequestWrapper<Demo>
{
    public DeleteDemoCommand(int id)
    {
        Id = id;
    }
    public int Id { get; }
}