using EFCoreExample.Data;
using EFCoreExample.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Register any new services into the dependency container
// we do this
builder.Services.AddScoped<IUserService, UserService>();
//FIXME: builder.Services.AddScoped<IProfileService, ProfileService>();
//FIXME: builder.Services.AddScoped<ICategoryService, CategoryService>();
//FIXME: builder.Services.AddScoped<IProductService, ProductService>();


builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

/*
TODO: 
Add:
    CategoriesService
    ICategeoriesService
    ProductService
    IProductService
    ProfileService
    IProfileService
    Uncomment FIXME
*/
