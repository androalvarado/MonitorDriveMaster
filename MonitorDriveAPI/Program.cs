using Microsoft.EntityFrameworkCore;
using MonitorDriveAPI.Data;
using MonitorDriveAPI.Mappings;
using MonitorDriveAPI.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//depency injection
builder.Services.AddDbContext<ApplicationDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IUserRepository, SqlUserRepository>();
builder.Services.AddScoped<IDriverRepository, SqlDriverRepository>();
builder.Services.AddScoped<IPhoneRepository, SqlPhoneRepository>();
builder.Services.AddScoped<IVehicleRepository, SqlVehicleRepository>();

builder.Services.AddAutoMapper(typeof(AutoMapperProfiles));

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
