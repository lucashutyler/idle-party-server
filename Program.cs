var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapHeartbeatEndpoint();

app.Run();
