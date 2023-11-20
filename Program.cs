using Bootcamp_23_todo_list_api.library.Models;
using Bootcamp_23_todo_list_api.library.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddDbContext<Bootcamp23DemoContext>(options =>
    options.UseSqlServer(builder.Configuration.GetSection("ConnectionStrings")["DefaultConnection"]));

builder.Services.AddScoped<IToDoListService, ToDoListService>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
