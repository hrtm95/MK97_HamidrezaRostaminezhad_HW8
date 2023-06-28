using HW8;
using HW8.Models;
using HW8.Ripository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IUserRipository, UserRipository>();
builder.Services.AddScoped<ITurnoverRiposytory, TurnoverRiposytor>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.Use(async (ctx, next) =>
{
    var log = new Log()
    {
        timesstamp = DateTime.Now,
        Url = ctx.Request.Path,
        resultStatusCode = ctx.Response.StatusCode
    };
    var FilePath = @"wwwroot/Logs/log.txt";
    using (var writer = File.AppendText(FilePath))
    {
        writer.WriteLine($"Timestamp :{log.timesstamp},Url :{log.Url},StatusCode :{log.resultStatusCode}");
    }
    await next();
});
app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
