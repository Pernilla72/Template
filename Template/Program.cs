var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddGraphQLServer()


    .AddMutationType(m => m.Name("Mutation"))
    .AddType<BookMutation>()
    .AddMutationConventions(applyToAllMutations: true)

    .AddQueryType(q => q.Name("Query"))
    .AddType<TestQuery>()
    .AddType<BookQuery>()
    .AddType<GetAuthorQuery>()
    .AddDefaultTransactionScopeHandler();


builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
//builder.Services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));  tog denna från OrderAPI, men måste nog grejas lite med.../P

builder.Services.AddEndpointsApiExplorer();



var app = builder.Build();
app.MapGraphQL();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{

}

app.UseHttpsRedirection();

//app.UseAuthorization();

//app.MapControllers();

app.Run();

