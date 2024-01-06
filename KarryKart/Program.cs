using Entities.Data;
using Contracts;
using Microsoft.EntityFrameworkCore;
using Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataContext>(optionsAction: options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("Data")));
builder.Services.AddScoped<IParentrepo, ParentCategoryRepository>();
builder.Services.AddScoped<Icategoryrepo, CategoryRepository>();
builder.Services.AddScoped<IManufacturers, ManufacturerRepository>();


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
