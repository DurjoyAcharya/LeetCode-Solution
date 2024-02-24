//using WebBooks.Models;

using WebBooks.Configurations;
using WebBooks.Repositories;
using WebBooks.Services;

namespace WebBooks;
public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        //connection of mongodb 
        builder
            .Services
            .Configure<DbSettings>(builder.Configuration.GetSection("DbSettings"));
        builder.Services.AddControllers();
        builder.Services.AddSingleton<IProductRepository, ProductRepository>();
        builder.Services.AddTransient<IProductService, ProductService>();
       
        builder.Services.AddAuthorization();
        
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        
        var app = builder.Build();
        
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();
        app.UseAuthorization();
        app.MapControllers();
        app.Run();
    }
}