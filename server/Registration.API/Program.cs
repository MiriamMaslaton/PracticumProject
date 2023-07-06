using Microsoft.EntityFrameworkCore;
using Registration.Context;
using Registration.Repositories.Interface;
using Registration.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddCors(opt => opt.AddPolicy("PolicyName", policy =>
{
    policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
}));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



builder.Services.AddDbContext<IContext, MyDbContext>();

builder.Services.AddServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
//builder.Services.AddCors(c =>
//{
//    c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin().AllowAnyMethod().
//     AllowAnyHeader());
//});

app.UseCors("PolicyName");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();