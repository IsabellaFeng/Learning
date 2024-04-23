using LearnMediator;
using LearnMediator.scenarios.CreateOrder;
using Microsoft.AspNetCore.Mvc;
using MediatR;
using Microsoft.AspNetCore.Components.Forms;
using LearnEvents;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddLearnMediator();
builder.Services.AddFileWatcher();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.MapGet("/startFileWatcher", ([FromServices] FileWatcherSubscriber fileWatcherSubscriber) => {
    fileWatcherSubscriber.Start();
    return true;
});
app.MapGet("/stopFileWatcher", ([FromServices] FileWatcherSubscriber fileWatcherSubscriber) => {
    fileWatcherSubscriber.Stop();
    return true;
});
app.MapPost("/createOrder", async ([FromBody] CreateOrderCommand request, [FromServices] IMediator mediator) => {
    var response = await mediator.Send(request);
    return response.Success ? response.DisplayText : "Error";
});

app.Run();
    