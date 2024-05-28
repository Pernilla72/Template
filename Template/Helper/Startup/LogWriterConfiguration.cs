namespace Template.Helper.Startup;

/// <summary>
/// Set up things related to the log writer
/// </summary>
public static class LogWriterConfiguration
{
    /// <summary>
    /// Add the log writer to the service collection
    /// </summary>
    public static void ConfigureLogWriter(this IServiceCollection services)
    {
        //services.AddScoped<ILogWriter>(provider =>
        //{
        //    string sessionId = GetSessionIdFromHeader(provider);
        //    Environment environment = provider.GetService<Environment>();
        //    if (environment == Environment.Test)
        //    {
        //        IConfigurationRoot config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
        //        DatabaseSettings databaseSettings = config.GetSection(nameof(DatabaseSettings)).Get<DatabaseSettings>()!;

        //        return new LogSqlWriter(provider.GetService<ApplicationName>(), environment, sessionId, databaseSettings.ApplicationSettingsConnectionString);
        //    }
        //    return new LogMsmqWriter(provider.GetService<ApplicationName>(), environment, sessionId);
        //});
    }

    private static string GetSessionIdFromHeader(IServiceProvider provider)
    {
        const string sessionIdName = "SessionID";
        HttpContext httpContext = provider.GetService<IHttpContextAccessor>()!.HttpContext!;
        IHeaderDictionary headers = httpContext.Request.Headers;
        string sessionId = headers[sessionIdName]!;

        return sessionId;
    }
}
