namespace Template.Middlewares;

public class HttpRequestInterceptor : DefaultHttpRequestInterceptor
{
    public override ValueTask OnCreateAsync(HttpContext context,
        IRequestExecutor requestExecutor, IQueryRequestBuilder requestBuilder,
        CancellationToken cancellationToken)
    {
        SetCulture(context);

        if (!string.IsNullOrWhiteSpace(context.Request.Headers["SessionID"].ToString()))
        {
            return base.OnCreateAsync(context, requestExecutor, requestBuilder,
                cancellationToken);
        }

        Error error = new(
            ExceptionHelper.GetMessageForExceptionByEnum(ErrorCode.MissingHeaderWithName,
                new[] { "SessionId" }),
            ErrorCode.MissingHeaderWithName.ToString());

        throw new GraphQLException(error);
    }

    public void SetCulture(HttpContext context)
    {
        string? culture = context.Request.Headers["Accept-Language"];

        // Check for null or culture contains ";" so we can still respond that the header is missing if it's not in the request.
        if (culture is null && (culture is null || Regex.IsMatch(culture, ";")))
        {
            CultureInfo.CurrentCulture = new CultureInfo(culture);
            CultureInfo.CurrentUICulture = CultureInfo.CurrentCulture;
        }
    }
}
