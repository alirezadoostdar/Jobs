using Hangfire;
using Hangfire.Redis.StackExchange;
using Microsoft.AspNetCore.Http;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHangfire(configure =>
{
    configure.UseRedisStorage("",)
});
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapPost("/upload", (IFormFile file, ILogger<Program> logger) =>
{
    //save
    Task.Run(async () => await DoSomeThing(file, logger));
    return Results.Ok;
}).DisableAntiforgery();

app.Run();


static async Task DoSomeThing(IFormFile streamFile,ILogger<Program> logger)
{
    await Task.Delay(10000);
    logger.LogInformation("done!");
}
