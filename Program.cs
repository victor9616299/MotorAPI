using DataAccess;
using DataAccess.Repositorios;
using DataAccess.Repositorios.Contratos;

var builder = WebApplication.CreateBuilder(args);

// Registra o contexto
builder.Services.AddDbContext<Contexto>();

// Registra o repositório de motores
builder.Services.AddScoped<IMotorRepositorio, MotorRepositorio>();

// Add services to the container.
builder.Services.AddControllers();

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Constrói a aplicação
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