using Backend.Context;
using Microsoft.EntityFrameworkCore;
// using Npgsql.EntityFrameworkCore.PostgreSQL;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//Crear cadena de conexion
var connectionString = builder.Configuration.GetConnectionString("Connection");
//registrar servicio para la conexion
builder.Services.AddDbContext<AppDbContext>(p => p.UseNpgsql(builder.Configuration.GetConnectionString("PostgresAppConnection")));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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

app.MapControllers();

app.Run();