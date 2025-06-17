using Microsoft.EntityFrameworkCore;
using SharedLibrary.DataModel;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.OpenApi.Models;
using Scalar.AspNetCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddControllers();

// Register the StockSalesTempService as a scoped service
builder.Services.AddScoped<SharedLibrary.Repository.Interface.IStockSalesTempService, SharedLibrary.Repository.Services.StockSalesTempService>();
builder.Services.AddSingleton<SharedLibrary.DataModel.Authentication.UserSession>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins", policy =>
    {
        policy.AllowAnyOrigin()   // Allow requests from any origin
              .AllowAnyMethod()   // Allow all HTTP methods (GET, POST, PUT, DELETE, etc.)
              .AllowAnyHeader();  // Allow all headers
    });
});

builder.Services.AddAuthentication().AddJwtBearer();

builder.Services.AddAuthorization(o =>
{
    o.AddPolicy("RequireAuthenticatedUser", policy =>
    {
        policy.RequireRole("Admin");
    });

});

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();


//builder.Services.AddAuthentication(options =>
//{
//    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
//    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
//})
//.AddJwtBearer(options =>
//{
//    options.TokenValidationParameters = new TokenValidationParameters
//    {
//        ValidateIssuer = true,
//        ValidateAudience = true,
//        ValidateLifetime = true,
//        ValidateIssuerSigningKey = true,
//        ValidIssuer = builder.Configuration["Jwt:Issuer"],
//        ValidAudience = builder.Configuration["Jwt:Audience"],
//        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
//    };
//});



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{

    app.MapOpenApi();
    app.MapScalarApiReference(); 
}

app.UseHttpsRedirection();

app.UseAuthentication(); // Add this line before UseAuthorization
app.UseAuthorization();

app.MapControllers();

app.Run();
