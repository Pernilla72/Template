
namespace Template.Helper.MediatR;

public interface IRequestWrapper<T> : IRequest<T> { }

public interface IHandlerWrapper<in Tin, TOut> : IRequestHandler<Tin, TOut>
    where Tin : IRequestWrapper<TOut>
{
    Task<Book> Handle(UpdateBookCommand request, bool isAvailable, CancellationToken cancellationToken);
}