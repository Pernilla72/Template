namespace Template.MediatR.Commands.Demos;

public class CreateDemoCommand : IRequestWrapper<Demo>
{
    public string Id { get; set; }
}
