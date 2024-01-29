using CulturalHeritageBL.DALModels;
using CulturalHeritageBL.Repositories;
using Microsoft.EntityFrameworkCore;
using NuGet.Versioning;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<CulturalHeritageContext>(options =>
{
    options.UseSqlServer("Name=ConnectionStrings:DefaultConnection");
});

builder.Services.AddAutoMapper(
    typeof(CulturalHeritageWebApp.Mapping.AutomapperProfile),
    typeof(CulturalHeritageBL.Mapping.AutomapperProfile)
    );

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IHeritageRepository, HeritageRepository>();
builder.Services.AddScoped<IAgeCategoryRepository, AgeCategoryRepository>();
builder.Services.AddScoped<IPhotographyRepository, PhotographyRepository>();
builder.Services.AddScoped<IVideoRepository, VideoRepository>();
builder.Services.AddScoped<IHeritageCategoryRepository, HeritageCategoryRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (!app.Environment.IsDevelopment())
//{
//    app.UseExceptionHandler("/Home/Error");
//}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
