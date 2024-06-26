using Joshy_api.Extensions;
using Joshy_api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.HttpOverrides;
using Joshy_api.Models;
using Joshy_api.Repository;
using Joshy_api.Interface;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
// using JoshyDbContext context = new JoshyDbContext();

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("JoshyDbConnectionString");
// Add services to the container.
builder.Services.AddControllers();
builder.Services.ConfigureCors();
builder.Services.AddDbContext<JoshyDbContext>(options => options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));
builder.Services.AddScoped<IOnXInterface,OnXRepository>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Configuration.GetValue<bool>("UseSwagger"))
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
if (app.Configuration.GetValue<bool>("UseDeveloperExceptionPage"))
    app.UseDeveloperExceptionPage();
else
    app.UseExceptionHandler("/error");

app.UseHttpsRedirection();
app.UseStaticFiles();

app.MapGet("/error", 
[EnableCors("MyCorsPolicy")]
[ResponseCache(NoStore = true)]
() => Results.Problem());
app.MapGet("/error/test", 
[EnableCors("MyCorsPolicy")]
[ResponseCache(NoStore = true)]
() => {throw new Exception("Errorrrrr....");});

app.MapGet("/cod/test",
[EnableCors("MyCorsPolicy")]
[ResponseCache(NoStore = true)]
() => 
Results.Text(
//         "<script>"
//     + "window.alert('Your client supports Javascript"
//     + "\\r\\n\\r\\n"
//     + $"Server Time(UTC): {DateTime.UtcNow.ToString("o")}"
//     + "\\r\\n"
//     + "Client Time (UTC): ' + new Date().toISOString());"
//     + "</script>"
//     +"<noscript>Your client does not support JavaScript</noscript>",
// "text/html"
    "<script>"
    +"window.alert('Your client supports Javascript"
    +"\\r\\n\\r\\n"
    +$"Server time(UTC): {DateTime.UtcNow.ToString("o")}"
    +"\\r\\n"
    +"Client time(UTC): ' + new Date().toISOString());"
    +"</script>"
    +"<noscript> Your client doesn't support Javascript </noscript>",
    "text/html"
));


app.MapControllers();

app.UseCors("MyCorsPolicy");

app.Run();
