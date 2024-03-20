using SignalR;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// This is actually injected 
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSignalR();





var app = builder.Build();
app.UseDefaultFiles();
app.UseStaticFiles();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


//
// app.UseDefaultFiles();
// app.UseStaticFiles();
app.MapHub<ChatHub>("/chat");
app.Run();
