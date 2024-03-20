using Grpc.Net.Client;
using gRPCGreeter;
using Grpc.Net.Client;
using gRPCGreeter.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddGrpc();

var app = builder.Build();
using var gc = GrpcChannel.ForAddress("http://localhost:5081");
var client = new Greeter.GreeterClient(gc);
// Configure the HTTP request pipeline.
app.MapGrpcService<GreeterService>();
app.MapGet("/",
    () =>
        "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

app.Run();