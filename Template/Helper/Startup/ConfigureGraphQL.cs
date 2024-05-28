namespace Template.Helper.Startup;

public static class ConfigureGraphQL
{
    /// <summary>
    /// Set up graphql in services
    /// </summary>
    public static void ConfigureGraphQlServices(this IServiceCollection services)
    {
        services
            .AddGraphQLServer()
            //.RegisterDbContext()
            .AddAuthorization()
            .AddSorting()
            .AddFiltering()
            .AddSorting()
            .AddProjections()
            .AddHttpRequestInterceptor<HttpRequestInterceptor>()

            .AddMutationType(m => m.Name("Mutation"))
            .AddType<DemoMutation>()

            .AddQueryType(q => q.Name("Query"))
            .AddType<DemoQuery>();
    }
}