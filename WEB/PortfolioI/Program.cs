var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();



app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

/*app.MapGet("/", () => "This is ny index!");
app.MapGet("/contact", () => "This is my Contact!");
app.MapGet("/projects", () => "These are my projects!");*/

app.Run();
