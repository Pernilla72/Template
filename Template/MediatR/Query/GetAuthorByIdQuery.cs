
namespace Template.MediatR.Query;

public class GetAuthorByIdQuery(): IRequestWrapper<Author>
{
    public int Id { get; set; }
    
}
    

