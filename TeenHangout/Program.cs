var builder = WebApplication.CreateBuilder(args);
// Enable Razor Pages to display the members and posts.
builder.Services.AddRazorPages();

var app = builder.Build();

app.UseStaticFiles();
app.MapRazorPages();

app.Run();
