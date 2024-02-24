using WebBooks.Models;
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
            .Configure<WebBookSettings>(builder.Configuration.GetSection("WebBookDatabase"));
        builder.Services.AddSingleton<WebBookService>();
        builder.Services.AddControllers();
        builder.Services.AddAuthorization();
        
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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
       // app.MapControllers();
        

        app.MapGet("/weatherforecast", (HttpContext httpContext) =>
            {
                var forecast = "ASP.NET 8";
                return forecast;
            })
            .WithName("GetWeatherForecast")
            .WithOpenApi();
        app.MapControllers();
        app.Run();
    }
}