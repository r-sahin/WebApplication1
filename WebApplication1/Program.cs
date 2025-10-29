using System.Reflection;
using WebApplication1.ManuelCQRS.Handlers.CommandHandlers;
using WebApplication1.ManuelCQRS.Handlers.QueryHandlers;
using WebApplication1.Models;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region Manuel CQRS
builder.Services.AddSingleton<GetAllProductQueryHandler>()
                            .AddSingleton<GetByIdProductQueryHandler>()
                            .AddSingleton<CreateProductCommandHandler>()
                            .AddSingleton<DeleteProductCommandHandler>();
#endregion
#region MediatR CQRS

builder.Services.AddMediatR(configuration =>
{
    configuration.RegisterServicesFromAssembly(typeof(ApplicationDbContext).Assembly);
});
#endregion




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
