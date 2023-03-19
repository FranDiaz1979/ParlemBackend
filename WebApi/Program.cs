using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Services;
using SQLiteDatabase;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ParlemDbContext>(options => options.UseSqlite("Data Source=/usr/local/bin/parlem.db"));
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICustomerService, CustomerService>();

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

var basedatos = new ParlemConnection();

app.Run();




