using MediatR;
using ShippingRequestService.API.Application.Commands;
using ShippingRequestService.API.Infrastructure.Options;
using ShippingRequestService.Domain.AggregatesModel;
using ShippingRequestService.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

builder.Services.Configure<ConnectionStringOption>(builder.Configuration.GetSection("ConnectionString"));
builder.Services.Configure<WebUrlOption>(builder.Configuration.GetSection("WebUrl"));

builder.Services.AddScoped<IShippingRequestRepository, ShippingRequestRepository>();

builder.Services.AddMediatR(cfg =>
{
    cfg.RegisterServicesFromAssembly(typeof(IMediator).Assembly);
    cfg.RegisterServicesFromAssembly(typeof(RequestShippingCommand).Assembly);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();