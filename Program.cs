var builder = WebApplication.CreateBuilder(args);



// Add services to the container.
builder.Services.AddCors();
var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseCors(option =>
{
    option.AllowAnyMethod();
    option.AllowAnyHeader();
    option.AllowAnyOrigin();
});

app.Use((context, next) =>
{
    next();
    return context.Response.WriteAsync("Hello world");
});


app.MapGet("/products", () =>
{
    return "The products endpoint is called";
});

app.Run();


