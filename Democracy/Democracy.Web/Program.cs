using Democracy.Web.Data;
using Democracy.Web.Middleware;
using Democracy.Web.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<PollsContext>();
builder.Services.AddScoped<IPollsManager, PollsManager>();

builder.Services.AddEntityFrameworkNpgsql()
    .AddDbContext<PollsContext>(opt => opt.UseNpgsql(builder.Configuration.GetConnectionString("PollsConnection")));

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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers(); 

app.UseMiddleware<ApiKeyMiddleware>();

app.Run();
