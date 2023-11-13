using Bootcamp_23_todo_list_api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();

var connection = builder.Configuration.GetConnectionString("ConnectionString:DefaultConnection");

builder.Services.AddDbContext<Bootcamp23DemoContext>(options =>
    options.UseSqlServer("Server=bootcamp23demo.database.windows.net; Database=bootcamp-23-demo; User ID=Bootcamp23Admin; Password=Bootcamp23Password1*;Trusted_Connection=False;Encrypt=True;"));

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

app.UseAuthorization();

app.MapControllers();

app.Run();
