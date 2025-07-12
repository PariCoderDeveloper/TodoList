using Application.FacadPattern;
using Application.Interfaces.FacadInterface;
using Application.Interfaces.UnitofWork;
using Microsoft.EntityFrameworkCore;
using Persistance.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<DatabaseContext>(options => options.UseSqlite("Data Source = todo.db"))
    .AddScoped<IUnitofWork> (sp => sp.GetRequiredService<DatabaseContext>());

// Use Facad (Facad Injection)
builder.Services.AddScoped<IFacadPattern, FacadPattern>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();
app.MapRazorPages()
   .WithStaticAssets();

app.Run();
