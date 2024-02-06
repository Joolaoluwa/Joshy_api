using Joshy_api.Extensions;
using Joshy_api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.HttpOverrides;
using Joshy_api.Models;
// using JoshyDbContext context = new JoshyDbContext();

var builder = WebApplication.CreateBuilder(args);

// Products healthCare = new(){
//     ProductName = "Savalon vitamins",
//     Price = 50m,
//     // ProductCategories = ProductCategories.HealthCare;
// };

// context.Products.Add(healthCare);

// Products skinCare = new()
// {
//     ProductName = "IV botanics",
//     Price = 100m,
//     // ProductCategories = ProductCategories.SkinCare
// };
// context.Add(skinCare);
// context.SaveChanges();
var connectionString = builder.Configuration.GetConnectionString("JoshyDbConnectionString");
// Add services to the container.
builder.Services.ConfigureCors();
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
