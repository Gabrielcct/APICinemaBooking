using APICinema.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add DbContext configuration for UserContext
builder.Services.AddDbContext<UserContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DevConnection"))
);

builder.Services.AddDbContext<AccountTypeContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DevConnection"))
);

// Add DbContext configurations for other classes if needed (e.g., BookingsContext, MovieContext, etc.)

// Configure the default request culture
/*var supportedCultures = new[] { new CultureInfo("en-US") };
var requestLocalizationOptions = new RequestLocalizationOptions
{
    DefaultRequestCulture = new RequestCulture("en-US"),
    SupportedCultures = supportedCultures,
    SupportedUICultures = supportedCultures
};

builder.Services.Configure<RequestLocalizationOptions>(options =>
{
    options.DefaultRequestCulture = requestLocalizationOptions.DefaultRequestCulture;
    options.SupportedCultures = requestLocalizationOptions.SupportedCultures;
    options.SupportedUICultures = requestLocalizationOptions.SupportedUICultures;
});*/

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseRequestLocalization(requestLocalizationOptions);
app.UseAuthorization();

app.MapControllers();

app.Run();
