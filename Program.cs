using Joshy_api.Extensions;
using Joshy_api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.HttpOverrides;
using Joshy_api.Models;
using Joshy_api.Repository;
using Joshy_api.Interface;
// using JoshyDbContext context = new JoshyDbContext();

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("JoshyDbConnectionString");
// Add services to the container.
builder.Services.ConfigureCors();
builder.Services.AddScoped<IOnXInterface, OnXRepository>();
builder.Services.AddDbContext<JoshyDbContext>(options => options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
// Configure the HTTP request pipeline.
if(app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
    app.UseHsts();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseCors("CorsPolicy");

app.Run();
