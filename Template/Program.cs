

using static Template.Middlewares.ExceptionHandlerMiddleware;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
//builder.Services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));  tog denna från OrderAPI, men måste nog grejas lite med.../P

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));

//builder.Services.ConfigureAuthentication(applicationName, SettingsService);
builder.Services.ConfigureLogWriter();


builder.Services.ConfigureGraphQlServices();

builder.Services.AddHttpResponseFormatter<CustomHttpResponseFormatter>();

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

