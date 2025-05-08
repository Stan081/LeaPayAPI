using Lea.Repository.Context;
using Lea.Repository.Implementations;
using Lea.Repository.Interfaces;
using Lea.Service;
using Lea.Service.Implementations;
using Lea.Service.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Lea.Service.Utils.ServiceRegistrations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connString = builder.Configuration.GetConnectionString("LeaPayDB");
builder.Services.AddDbContext<LeaContext>(options =>
{
    options.UseNpgsql(connString);
    options.LogTo(Console.WriteLine, LogLevel.Information); // Add logging
});
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Fix: Pass the configuration object instead of the builder itself
builder.Services.AddCoreServices(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
