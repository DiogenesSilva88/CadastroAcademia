using CadastroAcademia.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Configuração da conexão com o banco de dados
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Adicionar serviços para a API e Swagger
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "CadastroAcademia API", Version = "v1" });
});

var app = builder.Build();

// Configuração do Swagger
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "CadastroAcademia API v1");
    c.RoutePrefix = string.Empty;  // Acessa o Swagger na URL raiz (http://localhost:7236/)
});

app.UseHttpsRedirection();
app.MapControllers();

app.Run();
