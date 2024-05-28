namespace Template.Helper;

/// <summary>
/// Helper methods related to exceptions.
/// </summary>
public static class ExceptionHelper
{
    /// <summary>
    /// Searches for a translated string matching the provided ErrorCode.
    /// If none is found, makes it very clear that it's missing
    /// </summary>
    /// <param name="errorCode">The <see cref="ErrorCode"/> to find related error message for</param>
    /// <param name="stringArguments">Texts to fill into the found messages, if needed</param>
    /// <returns>A translated error message related to the chosen <see cref="ErrorCode"/></returns>
    public static string GetMessageForExceptionByEnum(ErrorCode errorCode, object[] stringArguments)
    {
        string translatedError = Resources.ResourceManager.GetString(errorCode.ToString(), CultureInfo.CurrentCulture) ?? string.Empty;

        if (string.IsNullOrEmpty(translatedError))
        {
            return $"MISSING TEXT FOR CODE: {errorCode}, LANGUAGE: {CultureInfo.CurrentCulture}";
        }

        string formattedString = translatedError;
        if (stringArguments.Length > 0)
        {
            formattedString = string.Format(translatedError, stringArguments);
        }
        return formattedString;
    }
}
