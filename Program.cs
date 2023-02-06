using ApiCliente.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connectionsString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddControllers();
builder.Services.AddDbContext<ApiDbContext>(options => options.UseSqlite(connectionsString));

var app = builder.Build();
app.MapControllers();

app.Run();
