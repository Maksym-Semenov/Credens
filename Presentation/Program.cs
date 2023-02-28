using AutoMapper;
using Credens.BLL.Implementations;
using Credens.DAL.AutoMapper;
using Credens.DAL.Domain.Entities;
using Credens.DAL.EF;
using Credens.DAL.Repositories.Implementations;
using Credens.Infrastructure.DTO;
using Credens.Infrastructure.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Security.Cryptography;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'AppContext' not found.");
;

builder.Services.AddDbContext<CredensDbContext>(options =>
    options.UseSqlServer(connectionString));


builder.Services.AddControllersWithViews();

builder.Services.AddScoped(typeof(IService<ProjectDTO>), typeof(ProjectService));

builder.Services.AddScoped(typeof(IRepository<ProjectDTO>), typeof(ProjectRepository));

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());


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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();