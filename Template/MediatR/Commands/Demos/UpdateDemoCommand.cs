namespace Template.MediatR.Commands.Demos;

public class UpdateDemoCommand : IRequestWrapper<Demo>
{
    public int Id { get; set; }   
}
