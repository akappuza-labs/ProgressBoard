using Microsoft.EntityFrameworkCore;
using ProgressBoardApp.BAL.Interfaces;
using ProgressBoardApp.BAL.Services;
using ProgressBoardApp.DAL.DataAccess;
using ProgressBoardApp.DAL.Interfaces;
using ProgressBoardApp.DAL.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Dependencies
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUnitOfWork, EFUnitOfWork>();
// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

string connection = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ProgressBoardContext>(options => options.UseSqlServer(connection));

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
