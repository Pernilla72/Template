namespace Template.Helper.Pipelines;

public class ValidationBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    where TRequest : IRequest<TResponse>
{
    private readonly IEnumerable<IValidator<TRequest>> _validators;

    public ValidationBehavior(IEnumerable<IValidator<TRequest>> validators) => _validators = validators;

    public Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        if (!_validators.Any())
        {
            return next();
        }

        ValidationContext<TRequest> context = new ValidationContext<TRequest>(request);

        List<string> errorsDictionary = _validators
            .Select(x => x.Validate(context))
            .SelectMany(x => x.Errors)
            .Where(x => x != null)
            .GroupBy(
                x => x.PropertyName,
                x => x.ErrorMessage,
                (propertyName, errorMessages) => new
                {
                    Key = propertyName,
                    Values = errorMessages.Distinct().ToArray()
                })
            .ToDictionary(x => x.Key, x => x.Values)
            .SelectMany(x => x.Value).ToList();


        if (errorsDictionary.Any())
        {
            IEnumerable<Error> errorList = errorsDictionary.Select(x => new Error(x, ErrorCode.ValidationError.ToString()));
            throw new QueryException(errorList);
        }
        return next();
    }
}
