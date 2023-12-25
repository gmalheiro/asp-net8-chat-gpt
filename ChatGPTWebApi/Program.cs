using ChatGPTWebApi.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var appName = "ChatGPT ASP.NET 8 Integration";

builder.AddChatGpt();
builder.AddSerilog(builder.Configuration,"AspNet8 with ChatGPT");

builder.Services.AddControllers();

builder.Services.AddSwagger(builder.Configuration, appName);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwaggerDoc(appName);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
