using FlyweightPattern.Factories;
using FlyweightPattern.Managers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<ICarFactory, CarFactory>();
builder.Services.AddSingleton<ICarManager[]>(x => new CarManager[] {
    new CarManager(x.GetService<ICarFactory>(), "bmw"),
    new CarManager(x.GetService<ICarFactory>(), "audi"),
    new CarManager(x.GetService<ICarFactory>(), "bmw"),
    new CarManager(x.GetService<ICarFactory>(), "audi"),
});

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

app.Run();
