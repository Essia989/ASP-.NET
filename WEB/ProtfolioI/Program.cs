var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "This is my index!");
app.MapGet("/projects", () => "These are my projects !");
app.MapGet("/contact", () => "This is my Contact!");

app.Run();
