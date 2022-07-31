using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IMovieService,MovieManager>();
builder.Services.AddSingleton<IMovieDal, EfMovieDal>();

builder.Services.AddSingleton<ICategoryService, CategoryManager>();
builder.Services.AddSingleton<ICategoryDal, EfCategoryDal>();

builder.Services.AddSingleton<IActorService, ActorManager>();
builder.Services.AddSingleton<IActorDal, EfActorDal>();

builder.Services.AddSingleton<IProducerService, ProducerManager>();
builder.Services.AddSingleton<IProducerDal, EfProducerDal>();

builder.Services.AddSingleton<ICinemaService, CinemaManager>();
builder.Services.AddSingleton<ICinemaDal, EfCinemaDal>();


// Add services to the container.
builder.Services.AddControllersWithViews();

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

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
