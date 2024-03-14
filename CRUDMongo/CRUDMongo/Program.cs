using CRUDMongo.models;
using CRUDMongo.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

    builder.Services.Configure<MovieDatabaseSettings>(
        builder.Configuration.GetSection("CinemaPalaceDatabase"));
    builder.Services.AddSingleton<MoviesService>();
    builder.Services.AddControllers()
        .AddJsonOptions(
            options => options.JsonSerializerOptions.PropertyNamingPolicy = null);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.Run();
