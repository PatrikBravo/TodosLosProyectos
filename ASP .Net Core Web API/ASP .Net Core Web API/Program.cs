using ASP_.Net_Core_Web_API.Models.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var MyAllowsSpecificOrigins = "_myAllowsSpecificOrigins";

builder.Services.AddCors(opc => { 
    opc.AddPolicy(name: MyAllowsSpecificOrigins, builder => { 
        builder.WithOrigins("http://localhost:57860").AllowAnyMethod().AllowAnyHeader(); 
    }); 
});


builder.Services.AddDbContext<EstatusContext>(opt =>{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("conexion"));
});


// Add services to the container.

builder.Services.AddControllers();
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

app.UseCors(MyAllowsSpecificOrigins);

app.UseAuthorization();

app.MapControllers();

app.Run();
