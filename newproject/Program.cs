using Microsoft.EntityFrameworkCore;
using newproject.DBContext;
using newproject.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services
    .AddDbContext<MidWifeDbContext>(options => options.UseSqlServer(builder.Configuration!.GetConnectionString("MideWifedb")!));

builder.Services.AddScoped<IAncOpdService, AncOpdService>();
//builder.Services.AddScoped<IDailyLogNOPDService, DailyLogNOPDService>();
builder.Services.AddScoped<IDailyLogServices, DailyLogServices>();
builder.Services.AddScoped<ITriageservice, Triageservice>();   
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
