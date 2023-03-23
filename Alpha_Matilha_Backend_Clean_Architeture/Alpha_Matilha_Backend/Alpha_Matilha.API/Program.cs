using Alpha_Matilha.Aplication.Interfaces;
using Alpha_Matilha.Aplication.Mappings;
using Alpha_Matilha.Aplication.Services;
using Alpha_Matilha.Domain.Interfaces;
using Alpha_Matilha.Infrastructure.Context;
using Alpha_Matilha.Infrastructure.Repositories;
using AutoMapper;
using FluentAssertions.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container. ConfigureService()

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddControllers();

//Adicionando ao ConfigureService os Services e os Repositorys.
builder.Services.AddScoped<IAddress_PersonRepository, Address_PersonRepository>();
builder.Services.AddScoped<IAddress_PersonService, Address_PersonService>();

builder.Services.AddScoped<IPersonRepository, PersonRepository>();
builder.Services.AddScoped<IPersonService, PersonService>();

builder.Services.AddScoped<IDogRepository, DogsRepository>();
builder.Services.AddScoped<IDogService, DogService>();

builder.Services.AddAutoMapper(typeof(DomainToDTOMappingProfile));

//var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<AlphaMatilhaContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

var app = builder.Build(); //Configure()

// Configure the HTTP request pipeline. equivalente ao metodo configure
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
