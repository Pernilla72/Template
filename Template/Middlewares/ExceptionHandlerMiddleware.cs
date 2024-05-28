namespace Template.Middlewares;

public class ExceptionHandlerMiddleware
{
    public class CustomHttpResponseFormatter : DefaultHttpResponseFormatter
    {
        protected override HttpStatusCode OnDetermineStatusCode(
            IQueryResult result, FormatInfo format,
            HttpStatusCode? proposedStatusCode)
        {
            if (result.Errors?.Count > 0 &&
                 result.Errors.Any(error => error.Code == ErrorCode.ValidationError.ToString() || error.Code == ErrorCode.MissingHeaderWithName.ToString()))
            {
                return HttpStatusCode.BadRequest;
            }

            // In all other cases let Hot Chocolate figure out the
            // appropriate status code.
            return base.OnDetermineStatusCode(result, format, proposedStatusCode);
        }
    }
}
