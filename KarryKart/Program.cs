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
builder.Services.AddScoped<IProductrepo, ProductRepos>();
builder.Services.AddScoped<IDiscountRepos, DiscountRepos>();
builder.Services.AddScoped<ITaxRepos, TaxRepos>();
builder.Services.AddScoped<IVendorRepository, VendorRepository>();
builder.Services.AddScoped<IShippingRepos, ShippingRepos>();
builder.Services.AddScoped<IInventoryRepos, InventoryRepository>();
builder.Services.AddScoped<IGiftCard, GiftCardRepo>();
builder.Services.AddScoped<IDownload, DownloadRepos>();
builder.Services.AddScoped<IRentalRepo, RentalRepository>();
builder.Services.AddScoped<IRecurringProduct,RecurringProductRepo>();
builder.Services.AddScoped<ISEO,SEORepo>();








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
