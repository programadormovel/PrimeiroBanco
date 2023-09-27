using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<PrimeiroBanco.Models.BancoContext>(opt => opt.UseSqlServer("Server=localhost;Database=PETSHOP;Trusted_Connection=True;MultipleActiveResultSets=true;Integrated Security=false;User ID=sa;Password=Ad#1an01;Encrypt=False"));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
