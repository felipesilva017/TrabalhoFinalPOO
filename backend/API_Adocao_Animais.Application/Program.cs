using Microsoft.EntityFrameworkCore;
using API_Adocao_Animais.Application.Services;
using API_Adocao_Animais.Domain.Interfaces;
using API_Adocao_Animais.Domain.Entities;

var builder = WebApplication.CreateBuilder(args);

// Configuração dos serviços
builder.Services.AddDbContext<AdocaoDbContext>(options =>
    options.UseInMemoryDatabase("AdocaoDb"));

builder.Services.AddScoped<IAdocaoService, AdocaoService>();
builder.Services.AddScoped<IAdocaoRepository, AdocaoRepository>();

builder.Services.AddControllers();

// Adicionando serviços para Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowLocalhost", policy =>
    {
        policy.WithOrigins("http://localhost:5173")
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

var app = builder.Build();

// Configuração do pipeline de requisição
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowLocalhost");

app.UseRouting();

// Configuração das rotas
app.MapControllers();

using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<AdocaoDbContext>();

    context.Database.EnsureDeleted();
    context.Database.EnsureCreated();

    // Adicionar manualmente os dados iniciais
    if (!context.Animais.Any())
    {
        context.Abrigos.Add(new Abrigo { Id = 1, Nome = "Abrigo Central", Endereco = "Rua Principal, 123" });
        context.Animais.AddRange(new List<Animal>
        {
            new Cachorro { Id = 1, Nome = "Rex", Idade = 3, AbrigoId = 1 },
            new Gato { Id = 2, Nome = "Mia", Idade = 2, AbrigoId = 1 }
        });

        context.SaveChanges();
    }
}

app.Run();
