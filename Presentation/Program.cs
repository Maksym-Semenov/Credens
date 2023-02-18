using Credens.BLL.Implementations;
using Credens.BLL.Interface;
using Credens.DAL.Domain.Entities;
using Credens.DAL.EF;
using Credens.DAL.Repositories.Implementations;
using Credens.DAL.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

User user = new User();
user.FirstName = "qwe";
user.LastName = "asd";


//builder.Services.AddControllersWithViews();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'AppContext' not found.");
builder.Services.AddDbContext<CredensDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddControllersWithViews();
// Add services to the container.

builder.Services.AddScoped(typeof(IService<>), typeof(Service<>));
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

//app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();
