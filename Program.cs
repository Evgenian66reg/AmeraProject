var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () =>  "Server is running");
app.MapGet("/ping", () => "pong");
app.MapGet("/imfo", () => "Some info about OS");




app.Run();
