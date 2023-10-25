using Library.Infrastructure.Context;
using Library.Infrastructure.Interfaces;
using Library.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();


// Dependencia del contexto

builder.Services.AddDbContext<BibliotecaContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("BibliotecaContext")));
// Dependencia de los repositorios
builder.Services.AddTransient<INumeroCorrelativoRepository, NumeroCorrelativoRepository>();




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

app.UseAuthorization();

app.MapControllers();

app.Run();
