using ApiCliente.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddDbContext<ApiDbContext>();

var app = builder.Build();
app.MapControllers();

app.Run();
